
function SportsCar::onAdd(%this, %obj)
{
   Parent::onAdd(%this, %obj);

   %obj.setWheelTire(0,SportsCarTire);
   %obj.setWheelTire(1,SportsCarTire);
   %obj.setWheelTire(2,SportsCarTire);
   %obj.setWheelTire(3,SportsCarTire);

   // Setup the car with some tires & springs
   for (%i = %obj.getWheelCount() - 1; %i >= 0; %i--)
   {
      %obj.setWheelPowered(%i, true);
      %obj.setWheelSpring(%i, SportsCarSpring);
   }

   // Steer with the front tires
   %obj.setWheelSteering(0, 1);
   %obj.setWheelSteering(1, 1);

   // Add tail lights
   %obj.rightBrakeLight = new PointLight() 
   {
      radius = "1";
      isEnabled = "0";
      color = "1 0 0.141176 1";
      brightness = "2";
      castShadows = "1";
      priority = "1";
      animate = "0";
      animationPeriod = "1";
      animationPhase = "1";
      flareScale = "1";
      attenuationRatio = "0 1 1";
      shadowType = "DualParaboloidSinglePass";
      texSize = "512";
      overDarkFactor = "2000 1000 500 100";
      shadowDistance = "400";
      shadowSoftness = "0.15";
      numSplits = "1";
      logWeight = "0.91";
      fadeStartDistance = "0";
      lastSplitTerrainOnly = "0";
      representedInLightmap = "0";
      shadowDarkenColor = "0 0 0 -1";
      includeLightmappedGeometryInShadow = "0";
      rotation = "1 0 0 0";
      canSave = "1";
      canSaveDynamicFields = "1";
         splitFadeDistances = "10 20 30 40";
   };
   %obj.leftBrakeLight = new PointLight() 
   {
      radius = "1";
      isEnabled = "0";
      color = "1 0 0.141176 1";
      brightness = "2";
      castShadows = "1";
      priority = "1";
      animate = "0";
      animationPeriod = "1";
      animationPhase = "1";
      flareScale = "1";
      attenuationRatio = "0 1 1";
      shadowType = "DualParaboloidSinglePass";
      texSize = "512";
      overDarkFactor = "2000 1000 500 100";
      shadowDistance = "400";
      shadowSoftness = "0.15";
      numSplits = "1";
      logWeight = "0.91";
      fadeStartDistance = "0";
      lastSplitTerrainOnly = "0";
      representedInLightmap = "0";
      shadowDarkenColor = "0 0 0 -1";
      includeLightmappedGeometryInShadow = "0";
      rotation = "1 0 0 0";
      canSave = "1";
      canSaveDynamicFields = "1";
         splitFadeDistances = "10 20 30 40";
   };

   // Mount the brake lights
   %obj.mountObject(%obj.rightBrakeLight, %this.rightBrakeSlot);
   %obj.mountObject(%obj.leftBrakeLight, %this.leftBrakeSlot);
}

function SportsCar::onRemove(%this, %obj)
{
   Parent::onRemove(%this, %obj);

   if(isObject(%obj.rightBrakeLight))
      %obj.rightBrakeLight.delete();

   if(isObject(%obj.leftBrakeLight))
      %obj.leftBrakeLight.delete();

}

function serverCmdtoggleBrakeLights(%client)
{
   %car = %client.player.getControlObject();

   if (%car.getClassName() $= "WheeledVehicle")
   {
      if(%car.rightBrakeLight.isEnabled)
      {
         %car.rightBrakeLight.setLightEnabled(0);
         %car.leftBrakeLight.setLightEnabled(0);
      }
      else
      {
         %car.rightBrakeLight.setLightEnabled(1);
         %car.leftBrakeLight.setLightEnabled(1);
      }
   }
}

