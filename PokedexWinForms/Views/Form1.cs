using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PokedexWinForms.Models;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace PokedexWinForms
{
    public partial class frmPokedex : Form
    {
        public frmPokedex()
        {
            InitializeComponent();
        }

        #region variaveis

        string baseUrl = "https://pokeapi.co/api/v2/";
        string baseUrlPokemon = "https://pokeapi.co/api/v2/pokemon/";
        Pokemons pokemons = new Pokemons();
        #endregion

        private void GetAllPokemons()
        {
            //var baseAddress = new Uri(baseUrl);
            // client.BaseAddress = baseAddress;
            if (ltboxPoke.Items.Count == 0)
            {
                string url = "pokemon?limit=151&offset=0";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var results = response.Content.ReadAsStringAsync().Result;

                    pokemons = JsonConvert.DeserializeObject<Pokemons>(results);

                    foreach (var pokemon in pokemons.Results)
                    {
                        ltboxPoke.Items.Add(pokemon.Name.ToUpper());
                    }
                }

                lblCountPoke.Text = pokemons.Results.Count.ToString("000");
            }
        }
        private (string , poketypes) GetUrlGifPokemon(string pokemon)
        {
            string urlGif = "";
            poketypes poke = new poketypes();
            if (!string.IsNullOrEmpty(pokemon))
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseUrlPokemon);

                var response = client.GetAsync(pokemon).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    JObject json = JObject.Parse(content);

                    urlGif = (string)json["sprites"]["versions"]["generation-v"]["black-white"]["animated"]["front_default"];

                    try
                    {
                        poke.typeOne = (string)json["types"][0]["type"]["name"];
                        poke.typeTwo = (string)json["types"][1]["type"]["name"];
                    }
                    catch
                    {
                        poke.typeTwo = "";
                    }
                    
                }
            }


            return (urlGif, poke);
        }
        private Image GetImageFromUrl(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        Image image = Image.FromStream(stream);
                        return image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }

            return null;
        }
        private void BtnLoad(object sender, EventArgs e)
        {
            GetAllPokemons();
        }

        private void LtBoxPokeSelectedIndexChanged(object sender, EventArgs e)
        {
            int count = ltboxPoke.SelectedIndex + 1;
            lblCountPoke.Text = count.ToString("000");

            var obj = GetUrlGifPokemon(ltboxPoke.Text.ToLower());

            string url = obj.Item1;

            Image gifPokemon = GetImageFromUrl(url);
            pcboxPokemon.Image = gifPokemon;

            string type1 = obj.Item2.typeOne;

            label1.Text = type1.ToUpper();

            if(obj.Item2.typeTwo != "")
            {
                label1.Text += " / " + obj.Item2.typeTwo.ToUpper();
            }
        }

        private void BtnClearPokesClick(object sender, EventArgs e)
        {
            ltboxPoke.Items.Clear();
            lblCountPoke.Text = 0.ToString("000");
        }

        public class poketypes 
        {
            public string typeOne {  get; set; }   
            public string typeTwo { get; set; }
        }

    }
}
