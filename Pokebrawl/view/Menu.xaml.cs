using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Pokebrawl.model;

namespace Pokebrawl.view
{
    public partial class Menu : Page
    {
        public Menu(string avatarPath, List<string> equipePokemon)
        {
            InitializeComponent();
            DataContext = App.JoueurActuel;

            if (!string.IsNullOrEmpty(GameState.JoueurActuel.Avatar))
            {
                AvatarImage.Source = new BitmapImage(new Uri(GameState.JoueurActuel.Avatar, UriKind.RelativeOrAbsolute));
            }

            // Affichage de l’équipe Pokémon
            List<BitmapImage> sprites = new List<BitmapImage>();
            foreach (var p in GameState.JoueurActuel.Equipe)
            {
                sprites.Add(new BitmapImage(new Uri(p.Sprite, UriKind.RelativeOrAbsolute)));
            }
            EquipeSprites.ItemsSource = sprites;
        }

        private void Equipe_Click(object sender, RoutedEventArgs e)
        {
            var equipe = new List<Equipe.PokemonAffiche>
    {
            new Equipe.PokemonAffiche { Nom = "Bulbizarre", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/001.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Herbizarre", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/002.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Florizarre", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/003.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Salamèche", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/004.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Reptincel", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/005.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Dracaufeu", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/006.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Carapuce", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/007.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Carabaffe", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/008.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Tortank", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/009.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Chenipan", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/010.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Chrysacier", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/011.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Papilusion", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/012.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Aspicot", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/013.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Coconfort", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/014.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Dardargnan", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/015.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Roucool", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/016.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Roucoups", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/017.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Roucarnage", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/018.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Rattata", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/019.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Rattatac", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/020.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Piafabec", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/021.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Rapasdepic", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/022.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Abo", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/023.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Arbok", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/024.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Pikachu", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/025.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Raichu", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/026.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Sabelette", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/027.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Sablaireau", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/028.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Nidoran♀", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/029.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Nidorina", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/030.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Nidoqueen", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/031.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Nidoran♂", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/032.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Nidorino", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/033.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Nidoking", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/034.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Mélofée", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/035.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Mélodelfe", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/036.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Goupix", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/037.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Feunard", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/038.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Rondoudou", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/039.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Grodoudou", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/040.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Nosferapti", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/041.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Nosferalto", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/042.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Mystherbe", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/043.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Ortide", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/044.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Rafflesia", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/045.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Paras", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/046.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Parasect", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/047.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Mimitoss", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/048.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Aéromite", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/049.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Taupiqueur", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/050.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Triopikeur", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/051.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Miaouss", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/052.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Persian", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/053.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Psykokwak", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/054.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Akwakwak", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/055.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Férosinge", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/056.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Colossinge", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/057.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Caninos", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/058.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Arcanin", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/059.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Ptitard", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/060.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Têtarte", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/061.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Tartard", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/062.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Abra", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/063.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Kadabra", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/064.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Alakazam", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/065.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Machoc", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/066.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Machopeur", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/067.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Mackogneur", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/068.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Chétiflor", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/069.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Boustiflor", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/070.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Empiflor", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/071.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Tentacool", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/072.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Tentacruel", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/073.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Racaillou", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/074.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Gravalanch", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/075.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Grolem", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/076.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Ponyta", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/077.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Galopa", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/078.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Ramoloss", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/079.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Flagadoss", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/080.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Magnéti", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/081.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Magnéton", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/082.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Canarticho", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/083.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Doduo", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/084.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Dodrio", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/085.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Otaria", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/086.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Lamantine", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/087.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Tadmorv", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/088.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Grotadmorv", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/089.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Kokiyas", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/090.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Crustabri", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/091.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Fantominus", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/092.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Spectrum", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/093.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Ectoplasma", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/094.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Onix", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/095.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Soporifik", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/096.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Hypnomade", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/097.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Krabby", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/098.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Krabboss", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/099.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Voltorbe", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/100.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Électrode", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/101.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Noeunoeuf", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/102.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Noadkoko", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/103.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Osselait", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/104.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Ossatueur", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/105.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Kicklee", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/106.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Tygnon", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/107.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Excelangue", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/108.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Smogo", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/109.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Smogogo", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/110.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Rhinocorne", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/111.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Rhinoféros", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/112.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Leveinard", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/113.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Saquedeneu", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/114.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Kangourex", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/115.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Hypotrempe", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/116.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Hypocéan", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/117.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Poissirène", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/118.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Poissoroy", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/119.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Stari", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/120.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Staross", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/121.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "M. Mime", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/122.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Insécateur", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/123.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Lippoutou", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/124.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Élektek", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/125.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Magmar", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/126.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Scarabrute", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/127.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Tauros", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/128.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Magicarpe", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/129.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Léviator", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/130.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Lokhlass", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/131.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Métamorph", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/132.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Évoli", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/133.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Aquali", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/134.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Voltali", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/135.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Pyroli", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/136.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Porygon", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/137.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Amonita", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/138.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Amonistar", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/139.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Kabuto", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/140.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Kabutops", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/141.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Ptéra", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/142.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Ronflex", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/143.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Artikodin", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/144.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Électhor", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/145.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Sulfura", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/146.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Minidraco", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/147.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Draco", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/148.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Dracolosse", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/149.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Mewtwo", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/150.png", UriKind.Relative)) },
            new Equipe.PokemonAffiche { Nom = "Mew", Niveau = "Niv. 5", Sprite = new BitmapImage(new Uri("image/Icon/151.png", UriKind.Relative)) },

    };

            NavigationService?.Navigate(new Equipe(equipe));
        }

        private void Combat_Click(object sender, RoutedEventArgs e)
        {
            // À adapter : navigation vers le combat
            MessageBox.Show("Début du combat !");
        }
    }
}
