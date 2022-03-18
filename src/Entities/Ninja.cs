namespace dotnet___poo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(String Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
    
        }

        public override string Attack(){
            return this.Name + " Atacou com Shuriken!";
        }

        
    }
}