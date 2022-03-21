
public class PatientDensity
{
    public int Id { get; set; }
    public int NeighborhoodID { get; set; }
    public double Density { get; set; }
    public Color Color {get; set;}
    public Neigborhood Neigborhood {get; set;}
    public List<User>? Users {get; set;}
    
    public PatientDensity()
    {
        
    }

    public PatientDensity(CreateUpdatePatientDensityDTO _dto, double density)
    {
        NeighborhoodID = _dto.NeighborhoodID;
        Density = density;
        if(density < 0.3) Color = Color.Green;
        if(density < 0.6) Color = Color.Orange;
        else Color = Color.Red;
    }
}