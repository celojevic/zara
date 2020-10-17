﻿using System;

namespace ZaraEngine.StateManaging
{
    public class HealthStateStateContract
    {

        public float BloodPressureTop;
        public float BloodPressureBottom;
        public float HeartRate;
        public float BloodPercentage;
        public float FoodPercentage;
        public float WaterPercentage;
        public float OxygenPercentage;
        public float StaminaPercentage;
        public float FatiguePercentage;
        public float BodyTemperature;
        public DateTime LastSleepTime;
        public DateTime CheckTime;
        public bool IsBloodLoss;
        public bool IsActiveInjury;
        public bool IsActiveDisease;
        public bool IsFoodDisgust;
        public bool IsSleepDisorder;
        public bool CannotRun;
        public bool IsLegFracture;
        public int ActiveDiseasesWorstLevel;
        
        public ActiveDiseasesAndInjuriesContract ActiveDiseasesAndInjuries;

    }
}