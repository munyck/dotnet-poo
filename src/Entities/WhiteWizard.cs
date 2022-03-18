namespace dotnet___poo.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(String Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
    
        }
        public override string Attack(){
            return this.Name + " Lançou Magia da Luz!";
        }

    }
}