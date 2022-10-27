using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace BindingStatement.Observable
{
    public class ColorListLogic : ObservableObject
    {
        private ColorDescriptor _selectedColor;
        private bool _isAddFavoriteButtonEnable = false;

        public bool IsAddFavoriteButtonEnable
        {
            get => _isAddFavoriteButtonEnable;
            set => SetField(ref _isAddFavoriteButtonEnable, value);

        }
        public ColorDescriptor SelectedColor
        {
            get => _selectedColor;
            set
            {
                IsAddFavoriteButtonEnable = true;
                SetField(ref _selectedColor, value);
            }
        }

        private ColorDescriptor _selectedFavoriteColor;

        public ColorDescriptor SelectedFavoriteColor
        {
            get => _selectedFavoriteColor;
            set
            {
                OnPropertyChanged(nameof(IsRemoveButtonEnabled));
                SetField(ref _selectedFavoriteColor, value);
            }

        }

        public bool IsRemoveButtonEnabled => SelectedFavoriteColor != null;


        public ObservableCollection<ColorDescriptor> FavoriteColors { get; } = new ObservableCollection<ColorDescriptor>();
        public List<ColorDescriptor> LotsOfColors { get; private set; }

        public void AddSelectedColorToFavorites()
        {
            if(SelectedColor is null) return;

            FavoriteColors.Add(SelectedColor);

        }

        public void RemoveSelcetedFavoriteColor()
        {
            if(SelectedFavoriteColor == null)
                return;
            FavoriteColors.Remove(SelectedFavoriteColor);
            SelectedFavoriteColor=null;
        }

        public ColorListLogic()
        {
            LotsOfColors = new List<ColorDescriptor>
            {
                new ColorDescriptor(Colors.Red, "red"),
                new ColorDescriptor(Colors.White, "white"),
                new ColorDescriptor(Colors.Green, "green"),
                new ColorDescriptor(Colors.Yellow, "yellow"),
                new ColorDescriptor(Colors.Blue, "blue"),
                new ColorDescriptor(Colors.Black, "black")
            };

        }
    }
}
