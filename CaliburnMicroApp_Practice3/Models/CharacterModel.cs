using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnMicroApp_Practice3.Models
{
    /// <summary>
    /// Represents a particular character
    /// </summary>
    public class CharacterModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<AbilityModel> Abilities { get; set; }
        public string ImgName { get => Name.ToLower() + ".png"; }
    }
}
