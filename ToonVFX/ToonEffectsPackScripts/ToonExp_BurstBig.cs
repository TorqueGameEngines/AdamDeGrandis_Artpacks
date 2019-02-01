//-----------------------------------------------------------------------------
// Toon Effects Pack - Big Burst Explosion
//
// This file contains all the datablocks for the big burst explosion
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonExp_BurstBig.cs");


//-----------------------------------------------------------------------------
// Particle/Emitter Datablocks
//-----------------------------------------------------------------------------
datablock ParticleData(ToonExp_BurstBigStarsParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   //dragCoefficient      = "3";
   gravityCoefficient   = "2";   
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 50;
   spinRandomMin        = -120.0;
   spinRandomMax        = 120.0;

   sizes[0]      = "0.1";
   sizes[1]      = "0.5";
   sizes[2]      = "0.3";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.8 0.6 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstBigStarsEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;
   
   particles        = ToonExp_BurstBigStarsParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};


datablock ParticleData(ToonExp_BurstBigExplosionParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_explosion";
   gravityCoefficient   = "-0.2";   
   lifetimeMS           = 120;
   lifetimeVarianceMS   = 20;
   spinRandomMin        = -180.0;
   spinRandomMax        = 180.0;

   sizes[0]      = "1";
   sizes[1]      = "4";
   sizes[2]      = "2";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstBigExplosionEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 10;

   ejectionVelocity = 0.3;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 180.0;

   ejectionOffset   = 0.15;
   
   particles        = ToonExp_BurstBigExplosionParticle;
   blendStyle       = "ADDITIVE";
};

datablock ParticleData(ToonExp_BurstBigBlastParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_blast";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 150;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "1";
   sizes[1]      = "3";
   sizes[2]      = "2";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstBigBlastEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_BurstBigBlastParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};


datablock ParticleData(ToonExp_BurstBigSparkParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 150;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "1";
   sizes[1]      = "3";
   sizes[2]      = "2";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.9 0.8 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstBigSparkEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_BurstBigSparkParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};

datablock ParticleData(ToonExp_BurstBigVolumeParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 150;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "1";
   sizes[1]      = "2";
   sizes[2]      = "1";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.9 0.8 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstBigVolumeEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 30;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_BurstBigVolumeParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};


//-----------------------------------------------------------------------------
// Explosion Datablocks
//-----------------------------------------------------------------------------


datablock ExplosionData(ToonBurstBigExplosion)
{
   //soundProfile = CrossbowExplosionSound;
   lifeTimeMS = 70;
   
   particleEmitter = ToonExp_BurstBigVolumeEmitter; 
   particleDensity = 20;
   particleRadius = 0.3;

   // Point emission
   emitter[0] = ToonExp_BurstBigStarsEmitter; 
   emitter[1] = ToonExp_BurstBigExplosionEmitter; 
   emitter[2] = ToonExp_BurstBigBlastEmitter;
   emitter[3] = ToonExp_BurstBigSparkEmitter; 
   
   lightStartRadius = 2.0;
   lightEndRadius = 0.0;
   lightStartColor = "1 0.9 0.8";
   lightEndColor = "0.8 0.4 0.0";
   lightStartBrightness = 2.0;
   lightEndBrightness = 0.0;
   
};
