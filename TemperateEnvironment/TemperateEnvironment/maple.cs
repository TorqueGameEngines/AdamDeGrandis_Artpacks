
singleton TSShapeConstructor(MapleDae)
{
   baseShape = "./maple.dae";
   upAxis = "Z_AXIS";
   loadLights = "0";
};

function MapleDae::onLoad(%this)
{
   %this.addImposter("90", "8", "0", "0", "128", "0", "0");
}
