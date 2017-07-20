namespace DrawGame
{
    class Preference
    {
        public int GameId { get; set; }
        public bool LighsOn { get; set; }
        public bool SoundOn { get; set; }

        public ParticlesStyle ParticlesStyle { get; set; }

    }

    public enum ParticlesStyle { Snow=0 , Confetti=1,CoffeeBeans=2};
        
   
}
