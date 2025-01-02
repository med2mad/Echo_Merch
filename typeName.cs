using System.ComponentModel.DataAnnotations;

namespace Echo_Merch
{
	public class typeName
    {

		[Required( ErrorMessage = "retard")]
		[StringLength(5,MinimumLength=3)]
		public string a { get; set; }
        [Range(1, 2)]
        public int b { get; set; }

	}
}


