
singleton TSShapeConstructor(SportsCarDae)
{
   baseShape = "./sportsCar.DAE";
   upAxis = "Z_AXIS";
   loadLights = "0";
};


function SportsCarDae::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "0");
   %this.addSequence("ambient", "spring0", "1", "2");
   %this.addSequence("ambient", "spring1", "5", "6");
   %this.addSequence("ambient", "steering", "18", "19");
   %this.addSequence("ambient", "spring2", "9", "10");
   %this.addSequence("ambient", "spring3", "13", "14");
}
