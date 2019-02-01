singleton Material(sportsCarBodyMat)
{
   mapTo = "sportsCarBody";
   diffuseMap[0] = "art/shapes/sportsCar/sportsCar_diffuse";
   normalMap[0] = "art/shapes/sportsCar/sportsCar_normal.png";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "12";
   specularMap[0] = "art/shapes/sportsCar/sportsCar_spec.png";
   translucentBlendOp = "None";
   materialTag0 = "SportsCar";
   cubemap = "ChromeSimple";
};

singleton Material(sportsCarInteriorMat)
{
   mapTo = "sportsCarInterior";
   diffuseMap[0] = "art/shapes/sportsCar/sportsCarInterior_diffuse";
   normalMap[0] = "art/shapes/sportsCar/sportsCarInterior_normal.png";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "16";
   specularMap[0] = "art/shapes/sportsCar/sportsCarInterior_spec.png";
   translucentBlendOp = "None";
   materialTag0 = "SportsCar";
};

singleton Material(sportsCarGlassMat)
{
   mapTo = "sportsCarGlass";
   diffuseMap[0] = "art/shapes/sportsCar/sportsCarGlass_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "12";
   specularMap[0] = "art/shapes/sportsCar/sportsCarGlass_spec.png";
   castShadows = "0";
   translucent = "1";
   translucentBlendOp = "Sub";
   translucentZWrite = "1";
   alphaRef = "0";
   cubemap = "ChromeSimple";
   materialTag0 = "SportsCar";
};


singleton Material(sportsCarWheelAMat)
{
   mapTo = "SportsCarWheelA";
   diffuseMap[0] = "art/shapes/sportsCar/wheelA_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "12";
   translucentBlendOp = "None";
   normalMap[0] = "art/shapes/sportsCar/wheelA_normal.png";
   specularMap[0] = "art/shapes/sportsCar/wheelA_spec.png";
   cubemap = "ChromeSimple";
   materialTag0 = "SportsCar";
};
