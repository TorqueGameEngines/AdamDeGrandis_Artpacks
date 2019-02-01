//-----------------------------------------------------------------------------
// Temperate Environment Art Pack Demo Terrain Textures
// Copyright Adam deGrandis 2011
//-----------------------------------------------------------------------------

new TerrainMaterial()
{
   diffuseMap = "art/terrains/TemperateEnvironmentTerrain/grass01";
   internalName = "grass01";
   diffuseSize = "100";
   normalMap = "art/terrains/TemperateEnvironmentTerrain/grass01_normal";
   detailMap = "art/terrains/TemperateEnvironmentTerrain/grass01_detail";
   detailSize = "20";
   detailDistance = "200";
   detailStrength = "0.5";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/TemperateEnvironmentTerrain/rock01";
   normalMap = "art/terrains/TemperateEnvironmentTerrain/rock01_normal";
   detailMap = "art/terrains/TemperateEnvironmentTerrain/rock01_detail";
   internalName = "rock";
   diffuseSize = "70";
   detailSize = "100";
   detailDistance = "800";
   detailStrength = "0.5";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/TemperateEnvironmentTerrain/dirt01";
   diffuseSize = "100";
   detailSize = "20";
   detailDistance = "500";
   internalName = "dirt";
   normalMap = "art/terrains/TemperateEnvironmentTerrain/dirt01_normal";
   detailMap = "art/terrains/TemperateEnvironmentTerrain/dirt01_detail";
};
