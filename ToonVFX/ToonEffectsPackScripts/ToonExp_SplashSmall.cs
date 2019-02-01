//-----------------------------------------------------------------------------
// Toon Effects Pack - Small Splash 
//
// This file contains all the datablocks for the small slash
//
// Thanks for your support!
//
// Copyright Adam deGrandis 2012
//-----------------------------------------------------------------------------

//exec ("art/datablocks/ToonEffectsPack/ToonExp_SplashSmall.cs");


//-----------------------------------------------------------------------------
// Particle/Emitter Datablocks
//-----------------------------------------------------------------------------
datablock ParticleData(ToonExp_SplashSmallDropsParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_droplets";
   //dragCoefficient      = "3";
   gravityCoefficient   = "2";   
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 50;
   spinRandomMin        = -220.0;
   spinRandomMax        = 220.0;

   sizes[0]      = "1.5";
   sizes[1]      = "1";
   sizes[2]      = "0.5";

   colors[0] = "1 1 1 1";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_SplashSmallDropsEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 5;

   ejectionVelocity = 8;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 40.0;
   
   particles        = ToonExp_SplashSmallDropsParticle;
   blendStyle       = "NORMAL";
   ejectionOffset = "0.15";
};

datablock ParticleData(ToonExp_SplashSmallBlastParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_blast";
   //dragCoefficient      = "6";
   lifetimeMS           = 200;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "0.3";
   sizes[1]      = "3";
   sizes[2]      = "4";

   colors[0] = "1 1 1 1";
   colors[1] = "1 1 1 0.6";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_SplashSmallBlastEmitter)
{
   ejectionPeriodMS = 40;
   periodVarianceMS = 5;

   ejectionVelocity = 5;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 70.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_SplashSmallBlastParticle;
   blendStyle       = "ADDITIVE";
   ejectionOffset = "0.15";
};


datablock ParticleData(ToonExp_SplashSmallSparkParticle)
{
   textureName          = "art/shapes/particles/ToonEffectsPack/toon_spark";
   gravityCoefficient   = "3.0";   
   lifetimeMS           = 300;
   lifetimeVarianceMS   = 50;

   sizes[0]      = "0.4";
   sizes[1]      = "1";
   sizes[2]      = "0.4";

   colors[0] = "1 1 1 1";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0";
   
   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(ToonExp_SplashSmallSparkEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 10;
   velocityVariance = 0.2;

   thetaMin         = 0.0;
   thetaMax         = 40.0;

   orientParticles = "1";
   orientOnVelocity = "1";
   
   particles        = ToonExp_SplashSmallSparkParticle;
   blendStyle       = "NORMAL";
   ejectionOffset = "0.15";
};

//-----------------------------------------------------------------------------
// Explosion Datablocks
//-----------------------------------------------------------------------------


datablock ExplosionData(ToonSplashSmallExplosion)
{
   //soundProfile = CrossbowExplosionSound;
   lifeTimeMS = 100;

   // Point emission
   emitter[0] = ToonExp_SplashSmallDropsEmitter; 
   emitter[1] = ToonExp_SplashSmallBlastEmitter;
   emitter[2] = ToonExp_SplashSmallSparkEmitter; 
   
};
