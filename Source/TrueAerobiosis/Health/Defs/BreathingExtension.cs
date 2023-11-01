﻿using System.Collections.Generic;
using TAE;
using Verse;

namespace TAB.Health.Defs;

public class BreathingExtension : DefModExtension
{
    public RespiratoryProperties settings;
}

public class RespiratoryProperties
{
    public AtmosphericValueDef atmosphere;
    public float baseLevel = 0.21f;
    public List<BreathingStage> stages;
}

public class BreathingStage
{
    public string label;
    public float level;
    public List<HediffGiver> hediffGivers;
}