using Caliburn.Micro;
using CaliburnMicroApp_Practice3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CaliburnMicroApp_Practice3.ViewModels
{
    public class ShellViewModel : Screen
    {
        public BindableCollection<CharacterModel> Characters { get; set; } = new BindableCollection<CharacterModel>();
        private CharacterModel _selectedCharacter;

        public CharacterModel SelectedCharacter
        {
            get { return _selectedCharacter; }
            set 
            { 
                _selectedCharacter = value; 
                NotifyOfPropertyChange(() => SelectedCharacter);
            }
        }

        public ShellViewModel()
        {
            // Ideally, this data would come from some database and not be defined here in the UI
            Characters = new BindableCollection<CharacterModel>()
            {
                // Anduin
                new CharacterModel()
                {
                    Name = "Anduin",
                    Description = "Anduin Llane Wrynn is the King of Stormwind, High King of the Alliance, and commander of all Alliance forces.",
                    Abilities = new List<AbilityModel>() { new AbilityModel() { Name = "Consecration", Mana = 4, Color = "#f2e78f" } } 
                },

                // Gul'dan
                new CharacterModel()
                {
                    Name = "Gul'dan",
                    Description = "Gul'dan was the first orcish warlock as well as the de facto founder of the Horde. Tutored by the leaders of the Burning Legion, he is considered one of the most powerful warlocks to have ever existed. He founded the Shadow Council and created the first death knights.",
                    Abilities = new List<AbilityModel> { new AbilityModel() { Name = "Corrupting Mist", Mana = 2, Color = "#d276db" } }
                }
            };
        }

    }
}
