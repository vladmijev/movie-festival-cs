using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
	public class Genre
	{
        public string Name { get; set; }

        public Genre(string name)
        {
            this.Name = name;   
        }

        public string GetData()
        {
            return $"{Name[0]}{Name[Name.Length-1]}".ToUpper(); 
        }

	}
}
