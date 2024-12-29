using System.ComponentModel.DataAnnotations;

namespace Echo_Merch
{
	public class typeName
    {

		[Required( AllowEmptyStrings = true, ErrorMessage = "retard")]
		[StringLength(5,MinimumLength =3)]
		public string a { get; set; }
        public int b { get; set; }

	}
}


