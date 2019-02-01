//-----------------------------------------------------------------------------
// Toon Effects Pack - Small Splash 
//
// This file contains all the datablocks for the small slash
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonExp_SplashBig.cs");


//-----------------------------------------------------------------------------
// Particle/Emitter Datablocks
//-----------------------------------------------------------------------------
datablock ParticleData(ToonExp_SplashBigDropsParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_droplets";
   //dragCoefficient      = "3";
   gravityCoefficient   = "2";   
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 50;
   spinRandomMin        = -220.0;
   spinRandomMax        = 220.0;

   sizes[0]      = "3";
   sizes[1]      = "2";
   sizes[2]      = "1";

   colors[0] = "1 1 1 1";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_SplashBigDropsEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 12;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 50.0;
   
   particles        = ToonExp_SplashBigDropsParticle;
   blendStyle       = "NORMAL";
   ejectionOffset   = "0.3";
};

datablock ParticleData(ToonExp_SplashBigBlastParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_blast";
   lifetimeMS           = 300;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "0.6";
   sizes[1]      = "6";
   sizes[2]      = "8";

   colors[0] = "1 1 1 1";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_SplashBigBlastEmitter)
{
   ejectionPeriodMS = 40;
   periodVarianceMS = 5;

   ejectionVelocity = 7;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 80.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_SplashBigBlastParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.3";
};


datablock ParticleData(ToonExp_SplashBigSparkParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "3.0";   
   lifetimeMS           = 300;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "1";
   sizes[1]      = "3";
   sizes[2]      = "0.8";

   colors[0] = "1 1 1 1";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_SplashBigSparkEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 20;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 60.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_SplashBigSparkParticle;
   blendStyle       = "NORMAL";
   ejectionOffset = "0.3";
};

//-----------------------------------------------------------------------------
// Explosion Datablocks
//-----------------------------------------------------------------------------


datablock ExplosionData(ToonSplashBigExplosion)
{
   //soundProfile = CrossbowExplosionSound;
   lifeTimeMS = 100;

   // Point emission
   emitter[0] = ToonExp_SplashBigDropsEmitter; 
   emitter[1] = ToonExp_SplashBigBlastEmitter;
   emitter[2] = ToonExp_SplashBigSparkEmitter; 
   
};
