using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoes.Model
{
    class MenuMaker
    {
        #region Instance Fields
        private Random _random = new Random();
        private List<String> _meats = new List<string>() { "Roast beef", "Salami", "Turkey", "Ham", "pastrami" };
        private List<String> _condiments = new List<string>() { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        private List<String> _breads = new List<string>() { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        private int _numberOfItems;
        private ObservableCollection<MenuItem> _menu;
        private DateTime _generatedDate;
        private RelayCommand _createMenuCommand;

        #endregion

        #region Properties
        public int NumberOfItems { get { return _numberOfItems; } set { _numberOfItems = value; } }

        public ObservableCollection<MenuItem> Menu { get { return _menu; } private set { _menu = value; } }

        public DateTime GeneratedDate { get { return _generatedDate; } private set { _generatedDate = value; } }

        public Random Random { get { return _random; } set { _random = value; } }

        public List<string> Meats { get { return _meats; } set { _meats = value; } }

        public List<string> Condiments { get { return _condiments; } set { _condiments = value; } }

        public List<string> Breads { get { return _breads; } set { _breads = value; } }

        public RelayCommand CreateMenuCommand { get { return _createMenuCommand; } set { _createMenuCommand = value; } }

        #endregion

        #region Constructors
        public MenuMaker()
        {
            CreateMenuCommand = new RelayCommand(DoCreateMenu);
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }



        #endregion

        #region Methods
        private void DoCreateMenu(object obj)
        {
            UpdateMenu();
        }

        private MenuItem CreateMenuItem()
        {
            string randomMeat = Meats[Random.Next(Meats.Count)];
            string randomCondiment = Condiments[Random.Next(Condiments.Count)];
            string randomBread = Breads[Random.Next(Condiments.Count)];
            return new MenuItem(randomMeat, randomCondiment, randomBread);
        }
        public void UpdateMenu()
        {
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
        }
        #endregion
    }
}
