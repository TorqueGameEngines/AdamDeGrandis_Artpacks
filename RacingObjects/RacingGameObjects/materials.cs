singleton Material(RoadAsphalt_Mat)
{
   diffuseMap[0] = "art/shapes/RacingGameObjects/road_asphalt.png";
   normalMap[0] = "art/shapes/RacingGameObjects/road_asphalt_normal.png";
   materialTag0 = "RacingGameObjects";
   mapTo = "road_asphalt.png";
   specularMap[0] = "art/shapes/RacingGameObjects/road_asphalt_spec.png";
   specularPower[0] = "1";
};

singleton Material(RoadDirt_Mat)
{
   diffuseMap[0] = "art/shapes/RacingGameObjects/road_dirt.png";
   materialTag0 = "RacingGameObjects";
   mapTo = "road_asphalt.png";
   translucent = "1";
   castShadows = "0";
   alphaRef = "60";
   showDust = "1";
   normalMap[0] = "art/shapes/RacingGameObjects/road_dirt_normal.png";
   specularMap[0] = "art/shapes/RacingGameObjects/road_dirt_spec.png";
   translucentBlendOp = "LerpAlpha";
   translucentZWrite = "1";
};

singleton Material(gate_checkpoint_mat)
{
   mapTo = "gate_check";
   diffuseMap[0] = "art/shapes/RacingGameObjects/racingGate_check_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "12";
   translucentBlendOp = "None";
   normalMap[0] = "art/shapes/RacingGameObjects/racingGate_structure_normal.png";
   specularMap[0] = "art/shapes/RacingGameObjects/racingGate_structure_spec.png";
   materialTag0 = "RacingGameObjects";
};

singleton Material(gate_alpha_mat)
{
   mapTo = "gate_alpha";
   diffuseMap[0] = "art/shapes/RacingGameObjects/racingGate_crossbars_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "12";
   translucentBlendOp = "None";
   normalMap[0] = "art/shapes/RacingGameObjects/racingGate_crossbars_normal.png";
   pixelSpecular[0] = "1";
   alphaTest = "1";
   alphaRef = "64";
   materialTag0 = "RacingGameObjects";
   doubleSided = "1";
};


singleton Material(gate_finish_mat)
{
   mapTo = "gate_finish";
   diffuseMap[0] = "art/shapes/RacingGameObjects/racingGate_finish_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "12";
   translucentBlendOp = "None";
   normalMap[0] = "art/shapes/RacingGameObjects/racingGate_structure_normal.png";
   specularMap[0] = "art/shapes/RacingGameObjects/racingGate_structure_spec.png";
   materialTag0 = "RacingGameObjects";
};

singleton Material(gate_start_mat)
{
   mapTo = "gate_start";
   diffuseMap[0] = "art/shapes/RacingGameObjects/racingGate_start_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "12";
   translucentBlendOp = "None";
   normalMap[0] = "art/shapes/RacingGameObjects/racingGate_structure_normal.png";
   specularMap[0] = "art/shapes/RacingGameObjects/racingGate_structure_spec.png";
   materialTag0 = "RacingGameObjects";
};

singleton Material(turnsign_mat)
{
   mapTo = "turnsign";
   diffuseMap[0] = "art/shapes/RacingGameObjects/turnsign_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "12";
   translucentBlendOp = "None";
   normalMap[0] = "art/shapes/RacingGameObjects/turnsign_normal.png";
   specularMap[0] = "art/shapes/RacingGameObjects/turnsign_spec.png";
};
