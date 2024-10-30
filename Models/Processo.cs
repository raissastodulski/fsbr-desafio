using System.ComponentModel.DataAnnotations;
using fsbr_desafio.Services;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace fsbr_desafio.Models;

public class Processo
{
    public int Id { get; set; }
    
    [StringLength(100, MinimumLength = 5)]
    [Required]
    public string? Nome { get; set; }
    
    [StringLength(20, MinimumLength = 20, ErrorMessage = "NPU deve possuir 20 caracteres")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "NPU deve ser apenas númerico")]
    public string Npu { get; set; }
    
    [Display(Name = "Data de cadastro")]
    [DataType(DataType.DateTime)]
    public DateTime DataDeCadastro { get; set; } = DateTime.Now;
    
    [Display(Name = "Data de visualização")]
    [DataType(DataType.Date)]
    public DateTime? DataDeVisualizacao { get; set; }
    
    
    [Required]
    [Display(Name = "Município")]
    public string Municipio { get; set; }


    [Required]
    [Display(Name = "UF")]
    [StringLength(2, MinimumLength = 2, ErrorMessage = "UF deve conter 2 caracteres")]
    public string Uf { get; set; }
    
}