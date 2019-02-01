//-----------------------------------------------------------------------------
// Toon Effects Pack - Big Smoke Puff Explosion
//
// This file contains all the datablocks for the big puff explosion
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonExp_PuffBig.cs");


//-----------------------------------------------------------------------------
// Particle/Emitter Datablocks
//-----------------------------------------------------------------------------

datablock ParticleData(ToonExp_PuffBigSmokeParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_smoke";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 800;
   lifetimeVarianceMS   = 200;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = "1";
   sizes[1]      = "7";
   sizes[2]      = "10";

   colors[0] = "1 0.7 0.3 0.1";
   colors[1] = "0.9 0.8 1 0.9";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_PuffBigSmokeEmitter)
{
   ejectionPeriodMS = 30;
   periodVarianceMS = 10;

   ejectionVelocity = 0.5;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 100.0;

   ejectionOffset   = 2;
   
   particles        = ToonExp_PuffBigSmokeParticle;
   blendStyle       = "NORMAL";
};


datablock ParticleData(ToonExp_PuffBigStarsParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   dragCoefficient      = "3";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 800;
   lifetimeVarianceMS   = 50;
   spinRandomMin        = -120.0;
   spinRandomMax        = 120.0;

   sizes[0]      = "0.2";
   sizes[1]      = "2";
   sizes[2]      = "0.4";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.8 0.6 1";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_PuffBigStarsEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;
   
   particles        = ToonExp_PuffBigStarsParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.3";
};


datablock ParticleData(ToonExp_PuffBigSparkParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "0.0";   
   lifetimeMS           = 300;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "2";
   sizes[1]      = "6";
   sizes[2]      = "8";

   colors[0] = "1 0.9 0.8 1";
   colors[1] = "1 0.9 0.8 0.5";
   colors[2] = "0.8 0.4 0 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_PuffBigSparkEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_PuffBigSparkParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.3";
};

datablock ParticleData(ToonExp_PuffBigStarsSmallParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_starBig";
   dragCoefficient      = "3";
   gravityCoefficient   = "-0.1";   
   lifetimeMS           = 800;
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

datablock ParticleEmitterData(ToonExp_PuffBigStarsSmallEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 120.0;
   
   particles        = ToonExp_PuffBigStarsSmallParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.3";
};


//-----------------------------------------------------------------------------
// Explosion Datablocks
//-----------------------------------------------------------------------------


datablock ExplosionData(ToonPuffBigExplosion)
{
   //soundProfile = CrossbowExplosionSound;
   lifeTimeMS = 100;

   // Point emission
   emitter[0] = ToonExp_PuffBigSmokeEmitter; 
   emitter[1] = ToonExp_PuffBigSparkEmitter;  
   emitter[2] = ToonExp_PuffBigStarsEmitter;
   emitter[3] = ToonExp_PuffBigStarsSmallEmitter;
   
   lightStartRadius = 3.0;
   lightEndRadius = 0.0;
   lightStartColor = "1 0.9 0.8";
   lightEndColor = "0.8 0.4 0.0";
   lightStartBrightness = 2.0;
   lightEndBrightness = 0.0;
   
};
