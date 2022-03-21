
    public class RiskSurveyBuilder
    {
        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RiskSurvey>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.UserId);
                entity.Property(e => e.Result);
                entity.Property(e => e.BodyTemperature);
                entity.Property(e => e.BodyPain);
                entity.Property(e => e.ShortnessOfBreath);
                entity.Property(e => e.RunnyNose);
                entity.Property(e => e.Cough);
                entity.Property(e => e.Result);
                entity.Property(e => e.ChronicIllness);
                entity.Property(e => e.SmellAndTaste);
                entity.HasOne(e => e.User).WithOne().HasForeignKey("RiskSurvey", "UserId");

            });

            SetDataToDB(modelBuilder);
        }
    }
