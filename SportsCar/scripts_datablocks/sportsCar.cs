datablock ParticleData(SportsCarTireParticle)
{
   textureName          = "art/shapes/buggy/dustParticle";
   dragCoefficient      = 2.0;
   gravityCoefficient   = -0.1;
   inheritedVelFactor   = 0.1;
   constantAcceleration = 0.0;
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 400;
   colors[0]     = "0.46 0.36 0.26 1.0";
   colors[1]     = "0.46 0.46 0.36 0.0";
   sizes[0]      = 1.0;
   sizes[1]      = 4.0;
};

datablock ParticleEmitterData(SportsCarTireEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 10;
   ejectionVelocity = "14.58";
   velocityVariance = 1.0;
   ejectionOffset   = 0.0;
   thetaMin         = 0;
   thetaMax         = 60;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "SportsCarTireParticle";
   //blendStyle = "ADDITIVE";
};

datablock WheeledVehicleTire(SportsCarTire)
{
   // Tires act as springs and generate lateral and longitudinal
   // forces to move the vehicle. These distortion/spring forces
   // are what convert wheel angular velocity into forces that
   // act on the rigid body.
   shapeFile = "art/shapes/sportsCar/sportsCarWheelA.DAE";
   staticFriction = "1";
   kineticFriction = "40";

   // Spring that generates lateral tire forces
   lateralForce = "18000";  //18000
   lateralDamping = "6000";
   lateralRelaxation = "1";

   // Spring that generates longitudinal tire forces
   longitudinalForce = "18000";
   longitudinalDamping = "4000";
   longitudinalRelaxation = "1";
   radius = "0.354542";
};


datablock WheeledVehicleSpring(SportsCarSpring)
{
   // Wheel suspension properties
   length = "0.1";             // Suspension travel
   force = "4000";              // Spring force
   damping = "3000";             // Spring damping
   antiSwayForce = "3";         // Lateral anti-sway force  
};


datablock WheeledVehicleData(SportsCar)
{
   //cubeReflectorDesc = TestReflectorDesc;  
   category = "Vehicles";
   shapeFile = "art/shapes/sportsCar/sportsCar.DAE";
   tireDB = "SportsCarTire";
   springDB = "SportsCarSpring";
   
   //emap = 1;

   mountPose[0] = sitting;
   numMountPoints = 6;

   useEyePoint = "1";  // Use the vehicle's camera node rather than the player's

   maxSteeringAngle = 0.585;  // Maximum steering angle, should match animation

   // 3rd person camera settings
   cameraRoll = false;        // Roll the camera with the vehicle
   cameraMaxDist = 7.8;       // Far distance from vehicle
   cameraOffset = 0.5;        // Vertical offset from camera mount point
   cameraLag = "0.04";           // Velocity lag of camera
   cameraDecay = 1.25;        // Decay per sec. rate of velocity lag

   // Rigid Body
   mass = "500";
   massCenter = "0 0 0.5";    // Center of mass for rigid body
   massBox = "0 0 0";         // Size of box used for moment of inertia,
                              // if zero it defaults to object bounding box
   drag = "10";                // Drag coefficient
   bodyFriction = 0.6;
   bodyRestitution = 0.4;
   minImpactSpeed = 5;        // Impacts over this invoke the script callback
   softImpactSpeed = 5;       // Play SoftImpact Sound
   hardImpactSpeed = 15;      // Play HardImpact Sound
   integration = "32";           // Physics integration: TickSec/Rate
   collisionTol = "0.05";        // Collision distance tolerance
   contactTol = "0.4";          // Contact velocity tolerance

   // Engine
   engineTorque = "12000";       // Engine power   orig=4300
   engineBrake = "10000";         // Braking when throttle is 0
   brakeTorque = "15000";        // When brakes are applied
   maxWheelSpeed = 50;        // Engine scale by current speed / max speed

   // Energy
   maxEnergy = 100;
   jetForce = 3000;
   minJetEnergy = 30;
   jetEnergyDrain = 2;

   // Sounds
   //engineSound = cheetahEngine;
   //squealSound = cheetahSqueal;
   softImpactSound = softImpact;
   hardImpactSound = hardImpact;

   // Dynamic fields accessed via script
   nameTag = 'SportsCar';
   maxDismountSpeed = 10;
   maxMountSpeed = 5;
   //mountPose0 = "sitting";
   //tireEmitter = "SportsCarTireEmitter";
   //dustEmitter = "SportsCarTireEmitter";
   //dustHeight = "1";

   // Mount slots
   rightHeadlightSlot = 3;
   leftHeadlightSlot = 2;
   rightBrakeSlot = 5;
   leftBrakeSlot = 4;
   mountPose0 = "sitting";
   density = "20";
   shadowSize = "256";
   observeThroughObject = "0";
};

