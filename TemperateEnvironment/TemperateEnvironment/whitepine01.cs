
singleton TSShapeConstructor(Whitepine01Dts)
{
   baseShape = "./whitepine01.dts";
};

function Whitepine01Dts::onLoad(%this)
{
   %this.removeImposter();
}
