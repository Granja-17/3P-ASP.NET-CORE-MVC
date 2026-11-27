using System.ComponentModel.DataAnnotations;
namespace EmployeesManagement.Models
{
public class Department
{
public int Id { get; set; }
  
[Required(ErrorMessage = "O nome é obrigatório.")]
[StringLength(100, MinimumLength = 3)]
public string Nome { get; set; } = string.Empty;
  
[Required(ErrorMessage = "A localização é obrigatória.")]
[StringLength(250)]
public string Localização { get; set; } = string.Empty;
  
public bool Ativo { get; set; } = True
  
}
}
