using System.ComponentModel.DataAnnotations;

namespace TreversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
		[Compare("Password", ErrorMessage ="Şifreler uyumlu değil")]
		public string ConfirmPassword { get; set; }
	}
}
