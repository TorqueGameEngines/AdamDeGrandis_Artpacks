singleton Material(GrassMat)
{
   diffuseMap[0] = "art/shapes/TemperateEnvironment/groundCover";
   mapTo = "groundCover";
   doubleSided = "1";
   castShadows = "0";
   alphaTest = "1";
   alphaRef = "50";
   showFootprints = "0";
   materialTag0 = "TemperateArtPack";
};

singleton Material(WhitePineBarkMat)
{
   mapTo = "pineBark";
   diffuseMap[0] = "art/shapes/TemperateEnvironment/whitePine_bark_diffuse";
   normalMap[0] = "art/shapes/TemperateEnvironment/whitePine_bark_normal.png";
   materialTag0 = "TemperateArtPack";
};

singleton Material(WhitePineBranchMat)
{
   mapTo = "pineBranch";
   translucentBlendOp = "None";
   diffuseMap[0] = "art/shapes/TemperateEnvironment/whitePine_branch_diffuse.png";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "70";
   materialTag0 = "TemperateArtPack";
   normalMap[0] = "art/shapes/TemperateEnvironment/whitePine_branch_normal.png";
};

singleton Material(MapleBranchMat)
{
   mapTo = "mapleBranch";
   diffuseMap[0] = "art/shapes/TemperateEnvironment/maple_branch_diffuse.png";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "TemperateArtPack";
   normalMap[0] = "art/shapes/TemperateEnvironment/maple_branch_normal.png";
   specularMap[0] = "art/shapes/TemperateEnvironment/maple_branch_spec.png";
};

singleton Material(MapleBarkMat)
{
   mapTo = "mapleBark";
   diffuseMap[0] = "art/shapes/TemperateEnvironment/maple_bark_diffuse";
   normalMap[0] = "art/shapes/TemperateEnvironment/maple_bark_normal.png";
   materialTag0 = "TemperateArtPack";
};
