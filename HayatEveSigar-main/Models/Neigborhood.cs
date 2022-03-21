public class Neigborhood
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Population { get; set; }
    public virtual District? District { get; set; }
    public int DistrictId { get; set; }

    public int PatientDensityId { get; set; }
    public PatientDensity PatientDensity { get; set; }

}