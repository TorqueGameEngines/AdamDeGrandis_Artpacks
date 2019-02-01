
singleton TSShapeConstructor(WhitePineDae)
{
   baseShape = "./whitePine.dae";
   upAxis = "Z_AXIS";
   loadLights = "0";
};

function WhitePineDae::onLoad(%this)
{
   %this.addImposter("90", "8", "0", "0", "128", "0", "0");
}
