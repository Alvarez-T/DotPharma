using DotPharma.Abstract;

namespace DotPharma.Medication;

public class Medicine
{
    public Sku Sku { get; set; }
    public MedicationGroup Group { get; set; }
    public Lab Lab { get; set; }
    public ActiveIngredient ActiveIngredient { get; set; }

}
