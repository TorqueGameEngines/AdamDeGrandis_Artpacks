//-----------------------------------------------------------------------------
// Toon Effects Pack - Standard Big Explosion
//
// This file contains all the datablocks for the big explosion
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonExp_StandardExplosionBig.cs");


//-----------------------------------------------------------------------------
// Particle/Emitter Datablocks
//-----------------------------------------------------------------------------

datablock ParticleData(ToonExp_StandardBigSmokeParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 1200;
   lifetimeVarianceMS   = 400;
   spinRandomMin        = -40.0;
   spinRandomMax        = 40.0;

   sizes[0]      = "1";
   sizes[1]      = "5";
   sizes[2]      = "8";

   colors[0] = "0.8 0.4 0.0 0.1";
   colors[1] = "0.6 0.4 0.4 0.7";
   colors[2] = "0.3 0.3 0.5 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardBigSmokeEmitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 5;

   ejectionVelocity = 1.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 100.0;

   ejectionOffset   = 2;
   
   particles        = ToonExp_StandardBigSmokeParticle;
   blendStyle       = "NORMAL";
};


datablock ParticleData(ToonExp_StandardBigExplosionParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_explosion";
   gravityCoefficient   = "-0.2";   
   lifetimeMS           = 150;
   lifetimeVarianceMS   = 50;
   spinRandomMin        = -180.0;
   spinRandomMax        = 180.0;

   sizes[0]      = "1";
   sizes[1]      = "8";
   sizes[2]      = "2";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardBigExplosionEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 10;

   ejectionVelocity = 0.5;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 180.0;

   ejectionOffset   = 0.3;
   
   particles        = ToonExp_StandardBigExplosionParticle;
   blendStyle       = "ADDITIVE";
};

datablock ParticleData(ToonExp_StandardBigBlastParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_blast";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 200;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "2";
   sizes[1]      = "6";
   sizes[2]      = "8";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardBigBlastEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 3;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_StandardBigBlastParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.3";
};


datablock ParticleData(ToonExp_StandardBigSparkParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 200;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "2";
   sizes[1]      = "6";
   sizes[2]      = "8";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.9 0.8 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardBigSparkEmitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_StandardBigSparkParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.3";
};


datablock ParticleData(ToonExp_StandardBigStarsParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   dragCoefficient      = "3";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 600;
   lifetimeVarianceMS   = 200;
   spinRandomMin        = -120.0;
   spinRandomMax        = 120.0;

   sizes[0]      = "0.1";
   sizes[1]      = "0.5";
   sizes[2]      = "0.2";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.8 0.6 0.4";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardBigStarsEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 30;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;
   
   particles        = ToonExp_StandardBigStarsParticle;
   blendStyle       = "ADDITIVE";
};


//-----------------------------------------------------------------------------
// Explosion Datablocks
//-----------------------------------------------------------------------------


datablock ExplosionData(ToonStandardBigExplosion)
{
   //soundProfile = CrossbowExplosionSound;
   lifeTimeMS = 100;

   // Volume
   particleEmitter = ToonExp_StandardBigStarsEmitter; 
   particleDensity = 40;
   particleRadius = 1;
   
   // Point emission
   emitter[0] = ToonExp_StandardBigSmokeEmitter; 
   emitter[1] = ToonExp_StandardBigExplosionEmitter; 
   emitter[2] = ToonExp_StandardBigBlastEmitter;
   emitter[3] = ToonExp_StandardBigSparkEmitter; 

   lightStartRadius = 11.0;
   lightEndRadius = 0.0;
   lightStartColor = "1 0.9 0.8";
   lightEndColor = "0.8 0.4 0.0";
   lightStartBrightness = 2.0;
   lightEndBrightness = 0.0;
   
};
