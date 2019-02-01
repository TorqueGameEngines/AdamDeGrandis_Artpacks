//-----------------------------------------------------------------------------
// Toon Effects Pack - Small Burst Explosion
//
// This file contains all the datablocks for the small burst explosion
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonExp_BurstSmall.cs");


//-----------------------------------------------------------------------------
// Particle/Emitter Datablocks
//-----------------------------------------------------------------------------
datablock ParticleData(ToonExp_BurstSmallStarsParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   //dragCoefficient      = "3";
   gravityCoefficient   = "2";   
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 50;
   spinRandomMin        = -120.0;
   spinRandomMax        = 120.0;

   sizes[0]      = "0.1";
   sizes[1]      = "0.3";
   sizes[2]      = "0.1";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.8 0.6 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstSmallStarsEmitter)
{
   ejectionPeriodMS = 35;
   periodVarianceMS = 5;

   ejectionVelocity = 8;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;
   
   particles        = ToonExp_BurstSmallStarsParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};


datablock ParticleData(ToonExp_BurstSmallExplosionParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_explosion";
   gravityCoefficient   = "-0.2";   
   lifetimeMS           = 80;
   lifetimeVarianceMS   = 20;
   spinRandomMin        = -180.0;
   spinRandomMax        = 180.0;

   sizes[0]      = "0.5";
   sizes[1]      = "2";
   sizes[2]      = "1";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstSmallExplosionEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 10;

   ejectionVelocity = 0.3;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 180.0;

   ejectionOffset   = 0.15;
   
   particles        = ToonExp_BurstSmallExplosionParticle;
   blendStyle       = "ADDITIVE";
};

datablock ParticleData(ToonExp_BurstSmallBlastParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_blast";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 100;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "0.5";
   sizes[1]      = "1.2";
   sizes[2]      = "0.5";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstSmallBlastEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 10;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_BurstSmallBlastParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};


datablock ParticleData(ToonExp_BurstSmallSparkParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 100;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "0.4";
   sizes[1]      = "1";
   sizes[2]      = "0.4";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.9 0.8 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_BurstSmallSparkEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 10;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_BurstSmallSparkParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};

//-----------------------------------------------------------------------------
// Explosion Datablocks
//-----------------------------------------------------------------------------


datablock ExplosionData(ToonBurstSmallExplosion)
{
   //soundProfile = CrossbowExplosionSound;
   lifeTimeMS = 100;

   // Point emission
   emitter[0] = ToonExp_BurstSmallStarsEmitter; 
   emitter[1] = ToonExp_BurstSmallExplosionEmitter; 
   emitter[2] = ToonExp_BurstSmallBlastEmitter;
   emitter[3] = ToonExp_BurstSmallSparkEmitter; 
   
   lightStartRadius = 2.0;
   lightEndRadius = 0.0;
   lightStartColor = "1 0.9 0.8";
   lightEndColor = "0.8 0.4 0.0";
   lightStartBrightness = 2.0;
   lightEndBrightness = 0.0;
   
};
