namespace dotnet___poo.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(String Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
    
        }

        public override string Attack(){
            return this.Name + " Lançou Magia das Trevas!";
        }

    }
}