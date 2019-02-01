//-----------------------------------------------------------------------------
// Toon Effects Pack - Standard Small Explosion
//
// This file contains all the datablocks for the small explosion
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonExp_StandardExplosionSmall.cs");


//-----------------------------------------------------------------------------
// Particle/Emitter Datablocks
//-----------------------------------------------------------------------------

datablock ParticleData(ToonExp_StandardSmallSmokeParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 700;
   lifetimeVarianceMS   = 200;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "0.5";
   sizes[1]      = "2.5";
   sizes[2]      = "4";

   colors[0] = "0.8 0.4 0.0 0.1";
   colors[1] = "0.6 0.4 0.4 0.7";
   colors[2] = "0.3 0.3 0.5 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardSmallSmokeEmitter)
{
   ejectionPeriodMS = 30;
   periodVarianceMS = 10;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 100.0;

   ejectionOffset   = 1;
   
   particles        = ToonExp_StandardSmallSmokeParticle;
   blendStyle       = "NORMAL";
};


datablock ParticleData(ToonExp_StandardSmallExplosionParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_explosion";
   gravityCoefficient   = "-0.2";   
   lifetimeMS           = 150;
   lifetimeVarianceMS   = 50;
   spinRandomMin        = -180.0;
   spinRandomMax        = 180.0;

   sizes[0]      = "0.5";
   sizes[1]      = "4";
   sizes[2]      = "1";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardSmallExplosionEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 10;

   ejectionVelocity = 0.3;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   ejectionOffset   = 0.15;
   
   particles        = ToonExp_StandardSmallExplosionParticle;
   blendStyle       = "ADDITIVE";
};

datablock ParticleData(ToonExp_StandardSmallBlastParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_blast";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 200;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "1";
   sizes[1]      = "3";
   sizes[2]      = "4";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "0.8 0.4 0 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardSmallBlastEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 10;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_StandardSmallBlastParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};


datablock ParticleData(ToonExp_StandardSmallSparkParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 200;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "1";
   sizes[1]      = "3";
   sizes[2]      = "4";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.9 0.8 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_StandardSmallSparkEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 10;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 180.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_StandardSmallSparkParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};

//-----------------------------------------------------------------------------
// Explosion Datablocks
//-----------------------------------------------------------------------------


datablock ExplosionData(ToonStandardSmallExplosion)
{
   //soundProfile = CrossbowExplosionSound;
   lifeTimeMS = 100;

   // Point emission
   emitter[0] = ToonExp_StandardSmallSmokeEmitter; 
   emitter[1] = ToonExp_StandardSmallExplosionEmitter; 
   emitter[2] = ToonExp_StandardSmallBlastEmitter;
   emitter[3] = ToonExp_StandardSmallSparkEmitter; 

   lightStartRadius = 7.0;
   lightEndRadius = 0.0;
   lightStartColor = "1 0.9 0.8";
   lightEndColor = "0.8 0.4 0.0";
   lightStartBrightness = 2.0;
   lightEndBrightness = 0.0;
   
};
