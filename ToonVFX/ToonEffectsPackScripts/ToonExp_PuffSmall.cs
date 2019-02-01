//-----------------------------------------------------------------------------
// Toon Effects Pack - Small Smoke Puff Explosion
//
// This file contains all the datablocks for the small puff explosion
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonExp_PuffSmall.cs");


//-----------------------------------------------------------------------------
// Particle/Emitter Datablocks
//-----------------------------------------------------------------------------

datablock ParticleData(ToonExp_PuffSmallSmokeParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 700;
   lifetimeVarianceMS   = 200;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "0.5";
   sizes[1]      = "3.5";
   sizes[2]      = "5";

   colors[0] = "1 0.7 0.3 0.1";
   colors[1] = "0.9 0.8 1 0.9";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_PuffSmallSmokeEmitter)
{
   ejectionPeriodMS = 30;
   periodVarianceMS = 10;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 100.0;

   ejectionOffset   = 1;
   
   particles        = ToonExp_PuffSmallSmokeParticle;
   blendStyle       = "NORMAL";
};


datablock ParticleData(ToonExp_PuffSmallStarsParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   dragCoefficient      = "3";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 700;
   lifetimeVarianceMS   = 50;
   spinRandomMin        = -120.0;
   spinRandomMax        = 120.0;

   sizes[0]      = "0.1";
   sizes[1]      = "1";
   sizes[2]      = "0.2";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.8 0.6 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_PuffSmallStarsEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 10;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;
   
   particles        = ToonExp_PuffSmallStarsParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};


datablock ParticleData(ToonExp_PuffSmallSparkParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 200;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "1";
   sizes[1]      = "3";
   sizes[2]      = "4";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.9 0.8 0.5";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_PuffSmallSparkEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 10;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_PuffSmallSparkParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};

//-----------------------------------------------------------------------------
// Explosion Datablocks
//-----------------------------------------------------------------------------


datablock ExplosionData(ToonPuffSmallExplosion)
{
   //soundProfile = CrossbowExplosionSound;
   lifeTimeMS = 100;

   // Point emission
   emitter[0] = ToonExp_PuffSmallSmokeEmitter; 
   emitter[1] = ToonExp_PuffSmallSparkEmitter;  
   emitter[2] = ToonExp_PuffSmallStarsEmitter;

   lightStartRadius = 3.0;
   lightEndRadius = 0.0;
   lightStartColor = "1 0.9 0.8";
   lightEndColor = "0.8 0.4 0.0";
   lightStartBrightness = 2.0;
   lightEndBrightness = 0.0;
   
};
