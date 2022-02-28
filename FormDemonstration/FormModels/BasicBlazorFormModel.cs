using System.ComponentModel.DataAnnotations;

namespace FormDemonstration.FormModels;

public class BasicBlazorFormModel
{
    [Required]
    public string ExampleString { get; set; } = "Blazor School";
}