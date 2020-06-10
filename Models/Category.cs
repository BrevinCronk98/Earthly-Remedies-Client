using System.Collections.Generic;
using EarthlyRemediesClient.Models;


namespace EarthlyRemediesClient.Models
{
    public class Category
    {
        public Category()
        {
            this.Remedies = new HashSet<CategoryRemedy>();
        }
        public int CategoryId { get; set;}
        public int Name { get; set; }
        public ICollection<CategoryRemedy> Remedies { get; set;}
        
    }
}