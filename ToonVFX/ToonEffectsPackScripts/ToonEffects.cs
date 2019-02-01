//-----------------------------------------------------------------------------
// Toon Effects Pack - Effects
//
// This file contains all the standard particle emitters that aren't used in
// the different explosions.
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonEffects.cs");

datablock ParticleEmitterNodeData(ToonEmitterNode)
{
   timeMultiple = 1;
};


//-----------------------------------------------------------------------------
// Smoke Plumes
//-----------------------------------------------------------------------------


datablock ParticleData(ToonSmokeWhiteSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";  
   lifetimeMS           = 2000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "0.7";
   sizes[1]      = "1.2";
   sizes[2]      = "2";

   colors[0] = "1 1 1 0.1";
   colors[1] = "0.9 0.8 1 0.9";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonSmokeWhiteSmallEmitter)
{
   ejectionPeriodMS = 150;
   periodVarianceMS = 30;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 70.0;

   ejectionOffset   = 0.1;
   
   particles        = ToonSmokeWhiteSmallParticle;
   blendStyle = "NORMAL";
};

datablock ParticleData(ToonSmokeWhiteBigParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";  
   lifetimeMS           = 4000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "1.5";
   sizes[1]      = "2.4";
   sizes[2]      = "4";

   colors[0] = "1 1 1 0.1";
   colors[1] = "0.9 0.8 1 0.9";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;


};

datablock ParticleEmitterData(ToonSmokeWhiteBigEmitter)
{
   ejectionPeriodMS = 150;
   periodVarianceMS = 30;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 70.0;

   ejectionOffset   = 0.5;
   
   particles        = ToonSmokeWhiteBigParticle;
   blendStyle = "NORMAL";
};

datablock ParticleData(ToonSmokeBlackSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 2000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "0.7";
   sizes[1]      = "1.2";
   sizes[2]      = "2";

   colors[0] = "0.1 0.1 0.1 0.1";
   colors[1] = "0.3 0.3 0.4 0.9";
   colors[2] = "0.3 0.3 0.4 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;


};

datablock ParticleEmitterData(ToonSmokeBlackSmallEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 50;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 50.0;

   ejectionOffset   = 0.1;
   
   particles        = ToonSmokeBlackSmallParticle;
   blendStyle = "NORMAL";
};


datablock ParticleData(ToonSmokeBlackBigParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 4000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "1.5";
   sizes[1]      = "2.4";
   sizes[2]      = "4";

   colors[0] = "0.1 0.1 0.1 0.0";
   colors[1] = "0.3 0.3 0.4 0.9";
   colors[2] = "0.3 0.3 0.4 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;


};

datablock ParticleEmitterData(ToonSmokeBlackBigEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 50;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 50.0;

   ejectionOffset   = 0.5;
   
   particles        = ToonSmokeBlackBigParticle;
   blendStyle = "NORMAL";
};

datablock ParticleData(ToonSmokeLitSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";  
   lifetimeMS           = 2000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "0.7";
   sizes[1]      = "1.2";
   sizes[2]      = "2";

   colors[0] = "0.8 0.4 0.0 0.1";
   colors[1] = "0.4 0.3 0.3 0.9";
   colors[2] = "0.2 0.2 0.3 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;


};

datablock ParticleEmitterData(ToonSmokeLitSmallEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 50;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 50.0;

   ejectionOffset   = 0.1;
   
   particles        = ToonSmokeLitSmallParticle;
   blendStyle = "NORMAL";
};


datablock ParticleData(ToonSmokeLitBigParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 4000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "1.5";
   sizes[1]      = "2.4";
   sizes[2]      = "4";

   colors[0] = "0.8 0.4 0.0 0.1";
   colors[1] = "0.4 0.3 0.3 0.9";
   colors[2] = "0.2 0.2 0.3 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;


};

datablock ParticleEmitterData(ToonSmokeLitBigEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 50;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 50.0;

   ejectionOffset   = 0.5;
   
   particles        = ToonSmokeLitBigParticle;
   blendStyle = "NORMAL";
};

//-----------------------------------------------------------------------------
// Fire
//-----------------------------------------------------------------------------


datablock ParticleData(ToonFireSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_flame";
   gravityCoefficient   = "-0.2";   
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 200;
   spinRandomMin        = -180.0;
   spinRandomMax        = 180.0;

   sizes[0]      = "0.5";
   sizes[1]      = "1";
   sizes[2]      = "0.2";

   colors[0] = "0.8 0.9 1 0.5";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonFireSmallEmitter)
{
   ejectionPeriodMS = 80;
   periodVarianceMS = 30;

   ejectionVelocity = 0.3;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 70.0;

   ejectionOffset   = 0.15;
   
   particles        = ToonFireSmallParticle;
   blendStyle = "ADDITIVE";
};



datablock ParticleData(ToonFireBigParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_flame";
   gravityCoefficient   = "-0.2";  
   lifetimeMS           = 1400;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -180.0;
   spinRandomMax        = 180.0;

   sizes[0]      = "1";
   sizes[1]      = "2";
   sizes[2]      = "0.2";

   colors[0] = "0.8 0.6 1 0.5";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonFireBigEmitter)
{
   ejectionPeriodMS = 70;
   periodVarianceMS = 30;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 70.0;

   ejectionOffset   = 0.5;
   
   particles        = ToonFireBigParticle;
   blendStyle = "ADDITIVE";
};



//-----------------------------------------------------------------------------
// Sparkles
//-----------------------------------------------------------------------------

datablock ParticleData(ToonSparkleSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -140.0;
   spinRandomMax        = 140.0;

   sizes[0]      = "0.1";
   sizes[1]      = "0.3";
   sizes[2]      = "0.1";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.6 0.4 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.3;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonSparkleSmallEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 30;

   ejectionVelocity = 0.6;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   ejectionOffset   = 0.2;
   
   particles        = ToonSparkleSmallParticle;
   blendStyle = "ADDITIVE";
};

datablock ParticleData(ToonSparkleBlueSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -140.0;
   spinRandomMax        = 140.0;

   sizes[0]      = "0.1";
   sizes[1]      = "0.3";
   sizes[2]      = "0.1";

   colors[0] = "0.8 0.9 1 1";
   colors[1] = "0.2 0.5 1 1";
   colors[2] = "0 0.2 0.8 0";
   
   times[0]      = 0.0;
   times[1]      = 0.3;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonSparkleBlueSmallEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 30;

   ejectionVelocity = 0.6;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   ejectionOffset   = 0.2;
   
   particles        = ToonSparkleBlueSmallParticle;
   blendStyle = "ADDITIVE";
};

datablock ParticleData(ToonSparkleGreenSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -140.0;
   spinRandomMax        = 140.0;

   sizes[0]      = "0.1";
   sizes[1]      = "0.3";
   sizes[2]      = "0.1";

   colors[0] = "0.8 1 0.9 1";
   colors[1] = "0.3 1 0.6 1";
   colors[2] = "0 0.8 0.2 0";
   
   times[0]      = 0.0;
   times[1]      = 0.3;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonSparkleGreenSmallEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 30;

   ejectionVelocity = 0.6;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   ejectionOffset   = 0.2;
   
   particles        = ToonSparkleGreenSmallParticle;
   blendStyle = "ADDITIVE";
};

datablock ParticleData(ToonSparkleRedSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 500;
   spinRandomMin        = -140.0;
   spinRandomMax        = 140.0;

   sizes[0]      = "0.1";
   sizes[1]      = "0.3";
   sizes[2]      = "0.1";

   colors[0] = "1 0.7 0.3 1";
   colors[1] = "0.9 0.2 0.1 1";
   colors[2] = "0.8 0 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.3;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonSparkleRedSmallEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 30;

   ejectionVelocity = 0.6;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   ejectionOffset   = 0.2;
   
   particles        = ToonSparkleRedSmallParticle;
   blendStyle = "ADDITIVE";
};
