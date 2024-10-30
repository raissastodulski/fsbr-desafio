using System.ComponentModel.DataAnnotations;
using fsbr_desafio.Services;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.SqlServer.Server;

namespace fsbr_desafio.Models;

public class Processo
{
    public int Id { get; set; }
    
    [StringLength(100, MinimumLength = 5)]
    [Required]
    public string? Nome { get; set; }
    
    [Display(Name = "NPU")]
    [StringLength(20, MinimumLength = 20, ErrorMessage = "NPU deve possuir 20 caracteres")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "NPU deve ser apenas númerico")]
    public string Npu { get; set; }

    [Display(Name = "NPU")]
    public string NpuFormatado { get {return Formatar.Npu(Npu);} }
    
    [Display(Name = "Data de cadastro")]
    [DataType(DataType.DateTime)]
    public DateTime DataDeCadastro { get; set; } = DateTime.Now;
    
    [Display(Name = "Data de visualização")]
    [DataType(DataType.DateTime)]
    public DateTime? DataDeVisualizacao { get; set; }
    
    
    [Display(Name = "Município")]
    public string Municipio { get; set; }


    [Display(Name = "UF")]
    public string Uf { get; set; }
    
}