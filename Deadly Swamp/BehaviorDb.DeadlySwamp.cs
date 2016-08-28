using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ DeadlySwamp = () => Behav()
        #region SummonMonster
    .Init("Deadly Swamp Summon",
                new State(
                    new State("PhaseShootPlayer",
                         new State("PhaseAttack1",
                            new Orbit(0.6, 7.5, 15, "Deadonus Swampen"),
                            new Shoot(10, projectileIndex: 0, count: 3, shootAngle: 45, coolDown: 1000),
                            new HpLessTransition(0.3, "PhaseRageOnPlayer")
                             ),
                         new State("PhaseRageOnPlayer",
                    new ConditionalEffect(ConditionEffectIndex.Armored),
                           new Follow(1.5, range: 1, coolDown: 500),
                            new Flash(0xffcc0000, 0.03, 200),
                            new Shoot(10, projectileIndex: 0, count: 4, shootAngle: 50, coolDown: 500)

                        ))))
        #endregion
        #region InvisShots
         .Init("Deadly Swamp Invis1",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible),
                           new Follow(0.2, range: 1, coolDown: 250),
                 new TimedTransition(6000, "PhaseDie"),
                    new State("FollowHim",
                         new State("PhaseAttack1",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 0, coolDown: 300),
                            new TimedTransition(150, "PhaseAttack2")
                        ),
                        new State("PhaseAttack2",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 15, coolDown: 300),
                            new TimedTransition(150, "PhaseAttack3")
                        ),
                        new State("PhaseAttack3",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 30, coolDown: 300),
                            new TimedTransition(150, "PhaseAttack4")
                        ),
                        new State("PhaseAttack4",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 45, coolDown: 300),
                            new TimedTransition(150, "PhaseAttack5")
                        ),
                        new State("PhaseAttack5",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 60, coolDown: 300),
                            new TimedTransition(150, "PhaseAttack6")
                        ),
                        new State("PhaseAttack6",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 75, coolDown: 300),
                            new TimedTransition(150, "PhaseAttack7")
                        ),
                        new State("PhaseAttack7",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 90, coolDown: 300),
                            new TimedTransition(150, "PhaseAttack8")
                        ),
                        new State("PhaseAttack8",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 105, coolDown: 300),
                            new TimedTransition(150, "PhaseAttack1")
                        ),
                        new State("PhaseDie",
                            new Suicide()
                        ))))

         .Init("Deadly Swamp Invis2",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible),
                           new Follow(0.25, range: 1, coolDown: 500),
                 new TimedTransition(6000, "PhaseDie"),
                    new State("FollowHim",
                         new State("PhaseAttack1",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 0, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack2")
                        ),
                        new State("PhaseAttack2",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 15, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack3")
                        ),
                        new State("PhaseAttack3",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 30, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack4")
                        ),
                        new State("PhaseAttack4",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 45, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack5")
                        ),
                        new State("PhaseAttack5",
                            new Shoot(45, projectileIndex: 0, count: 4, shootAngle: 57, fixedAngle: 60, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack6")
                        ),
                        new State("PhaseAttack6",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 75, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack7")
                        ),
                        new State("PhaseAttack7",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 90, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack8")
                        ),
                        new State("PhaseAttack8",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 105, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack1")
                        ),
                        new State("PhaseDie",
                            new Suicide()
                        ))))

         .Init("Deadly Swamp Invis3",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible),
                 new Orbit(0.5, 5, 9, "Deadonus Swampen"),
                 new TimedTransition(9000, "PhaseDie"),
                    new State("FollowHim",
                         new State("PhaseAttack1",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 0, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack2")
                        ),
                        new State("PhaseAttack2",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 15, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack3")
                        ),
                        new State("PhaseAttack3",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 30, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack4")
                        ),
                        new State("PhaseAttack4",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 45, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack5")
                        ),
                        new State("PhaseAttack5",
                            new Shoot(45, projectileIndex: 0, count: 4, shootAngle: 57, fixedAngle: 60, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack6")
                        ),
                        new State("PhaseAttack6",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 75, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack7")
                        ),
                        new State("PhaseAttack7",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 90, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack8")
                        ),
                        new State("PhaseAttack8",
                            new Shoot(45, projectileIndex: 0, count: 5, shootAngle: 55, fixedAngle: 105, coolDown: 300),
                            new TimedTransition(200, "PhaseAttack1")
                        ),
                        new State("PhaseDie",
                            new Suicide()
                        ))))
        #endregion
        #region Boss
            .Init("Deadonus Swampen",
                new State(
                    new OnDeathBehavior(new ApplySetpiece("DeadlySwampDeath")),
                    new State("PhaseWait",
                            new Taunt(1, 6000, "...zZzZz..."),
                            new ConditionalEffect(ConditionEffectIndex.Armored),
                        new HpLessTransition(0.95, "PhaseWhatsGoingOn")
                        ),
                    new State("PhaseWhatsGoingOn",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Flash(0xff003300, 0.02, 200),
                            new Taunt("What is this! Urgh, who is this trying to awaken me!"),
                            new TimedTransition(4000, "PhaseGettingAngry")
                        ),
                    new State("PhaseGettingAngry",
                            new Flash(0xff003300, 0.05, 50),
                            new Taunt(1, 6000, "...GrrRr..."),
                            new ConditionalEffect(ConditionEffectIndex.Armored),
                           new HpLessTransition(0.8, "PhaseGettingOnRageMode")
                    ),
                    new State("PhaseGettingOnRageMode",

                            new Taunt("Foolish beings! What made you think you were sharp enough to step on my swamp!"),
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Flash(0xffff0000, 0.01, 300),
                            new TimedTransition(6000, "PhaseTransformation")
                        ),
                    new State("PhaseTransformation",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Taunt("I will shred you apart!"),
                            new Flash(0xffff0000, 0.01, 100),
                            new SetAltTexture(1),
                            new TimedTransition(3000, "PhaseSummonDefender")
                        ),
                    new State("PhaseSummonDefender",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Flash(0xff003300, 0.01, 100),
                            new Taunt("Who do you think you are playing with... I'm not gonna waste time for you nonsenseal creatures... You shall never see me again!"),
                                new InvisiToss("Deadly Swamp Summon", range: 5.9, angle: 90, coolDown: 99999),
                                new InvisiToss("Deadly Swamp Summon", range: 6.9, angle: 180, coolDown: 99999),
                                new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 270, coolDown: 99999),
                                new InvisiToss("Deadly Swamp Summon", range: 5.9, angle: 360, coolDown: 99999),
                                new InvisiToss("Deadly Swamp Summon", range: 6.9, angle: 130, coolDown: 99999),
                                new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 230, coolDown: 99999),
                                new TimedTransition(5000, "PhaseWaitForDefenderToDie")
                        ),
                    new State("PhaseWaitForDefenderToDie",
                           new ConditionalEffect(ConditionEffectIndex.Invincible),
                           new SetAltTexture(2),
                           new EntityNotExistsTransition("Deadly Swamp Summon", 999, "PhaseComeBackRage")
                        ),
                    new State("PhaseComeBackRage",
                         new ConditionalEffect(ConditionEffectIndex.Armored),
                         new SetAltTexture(1),
                         new Flash(0xffff00ff, 0.05, 100),
                         new Taunt("You are so naive... You are irrelevant! Feel the wrath!"),
                         new Shoot(radius: 30, count: 3, shootAngle: 45, projectileIndex: 0, predictive: 20, coolDownOffset: 2000, coolDown: 1000),
                         new HpLessTransition(0.65, "PhaseMiniRagePrep")
                        ),
                    new State("PhaseMiniRagePrep",
                         new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                         new Flash(0xff993300, 0.01, 200),
                         new Taunt("Right! You seem very thoughtful of what you're doing... That won't last for long though..."),
                         new TimedTransition(5000, "PhaseMiniRage")
                        ),
                    new State("PhaseMiniRage",
                         new ConditionalEffect(ConditionEffectIndex.Armored),
                         new Flash(0xff003399, 0.1, 200),
                         new Shoot(radius: 30, count: 8, shootAngle: 80, projectileIndex: 0, predictive: 20, coolDownOffset: 2000, coolDown: 1500),
                         new Shoot(radius: 30, count: 6, shootAngle: 50, projectileIndex: 0, coolDownOffset: 500, coolDown: 2000),
                         new Shoot(radius: 30, count: 32, shootAngle: 360, projectileIndex: 1, coolDownOffset: 500, coolDown: 1000),

                         new HpLessTransition(0.4, "PhaseHealAndPrepMegaRage")
                        ),
                    new State("PhaseHealAndPrepMegaRage",
                         new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                         new Flash(0xffcc0000, 0.1, 200),
                         new Taunt("Ahaha! You idiotic things, prepare to die!"),
                         new Heal(1, "Self", 1000),
                         new TimedTransition(5000, "PhaseMegaRage")
                        ),
                    new State("PhaseMegaRage",
                         new ConditionalEffect(ConditionEffectIndex.Armored),
                         new Taunt("...Asabalbbabla... Summon whilst I have the power!"),
                         new Flash(0xffffff00, 0.2, 200),
                         new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 7000),
                         new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 7000),
                         new HpLessTransition(0.85, "PhaseSpawnDefenderAgain")
                        ),
                    new State("PhaseSpawnDefenderAgain",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                         new Taunt("You will not see the light of day again!"),
                            new Flash(0xff663300, 0.05, 100),
                            new InvisiToss("Deadly Swamp Summon", range: 5.9, angle: 90, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Summon", range: 6.9, angle: 180, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 270, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Summon", range: 5.9, angle: 360, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Summon", range: 6.9, angle: 130, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 230, coolDown: 99999),
                            new TimedTransition(5000, "PhaseWaitDefenderAgain")
                        ),
                    new State("PhaseWaitDefenderAgain",
                            new ConditionalEffect(ConditionEffectIndex.Invincible),
                            new SetAltTexture(2),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 6000),
                            new EntityNotExistsTransition("Deadly Swamp Summon", 999, "PhaseSuperRage")
                        ),
                    new State("PhaseSuperRage",
                            new ConditionalEffect(ConditionEffectIndex.Invincible),
                            new SetAltTexture(1),
                            new Flash(0xffcc0000, 0.01, 500),
                            new Taunt("Dull human... Can you survive this?!"),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Summon", range: 6.9, angle: 130, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 230, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 99999),
                            new InvisiToss("Deadly Swamp Invis3", range: 0, angle: 0, coolDown: 99999),
                            new TimedTransition(5000, "PhaseSuperRage2Prep")
                        ),
                    new State("PhaseSuperRage2Prep",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                            new SetAltTexture(2),
                            new InvisiToss("Deadly Swamp Invis3", range: 0, angle: 0, coolDown: 6000),
                        new EntityExistsTransition("Deadly Swamp Summon", 999, "PhaseSuperRage2")
                        ),
                    new State("PhaseSuperRage2",

                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                            new Taunt("I'm done... Playing about with you is getting a litle bit boring... Try to dodge this grenade... and..."),
                    new Grenade(5, 50, 32, coolDown: 1000),
                            new Flash(0xff0d0d0d, 0.04, 200),
                            new SetAltTexture(1),
                        new TimedTransition(5000, "PhaseFinal1")
                        ),
                    new State("PhaseFinal1",
                        new Wander(0.1),
                           new ConditionalEffect(ConditionEffectIndex.Armored),
                          new Grenade(5, 60, 32, coolDown: 5000),
                            new InvisiToss("Deadly Swamp Invis3", range: 0, angle: 0, coolDown: 10000),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 10000),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 10000),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 6.9, angle: 130, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 230, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis3", range: 0, angle: 0, coolDown: 9999999),
                            new HpLessTransition(2.5, "PhaseFinal2Prep")
                        ),
                    new State("PhaseFinal2Prep",

                        new Wander(0.1),
                        new Follow(0.86, range: 1, coolDown: 2500),
                         new Heal(1, "Self", 1000),
                         new TimedTransition(5000, "PhaseFinal2")
                        ),

                    new State("PhaseFinal2",
                           new ConditionalEffect(ConditionEffectIndex.Armored),
                          new Grenade(7, 100, 32, coolDown: 5000),
                          new Taunt(1, 8000, "Mindless creatures, I still have {HP} hit points!"),
                            new InvisiToss("Deadly Swamp Invis3", range: 0, angle: 0, coolDown: 9000),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 9000),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 9000),
                            new InvisiToss("Deadly Swamp Summon", range: 6.9, angle: 130, coolDown: 20000),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis1", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 6.9, angle: 130, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 230, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Summon", range: 7.9, angle: 150, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis2", range: 0, angle: 0, coolDown: 9999999),
                            new InvisiToss("Deadly Swamp Invis3", range: 0, angle: 0, coolDown: 9999999),
                         new Shoot(radius: 30, count: 8, shootAngle: 80, projectileIndex: 0, predictive: 20, coolDownOffset: 2000, coolDown: 1500),
                         new Shoot(radius: 30, count: 6, shootAngle: 50, projectileIndex: 0, coolDownOffset: 500, coolDown: 2000),
                         new Shoot(radius: 30, count: 32, shootAngle: 360, projectileIndex: 1, coolDownOffset: 500, coolDown: 1000),
                            new HpLessTransition(1, "PhaseDeath")
                        ),
                    new State("PhaseDeath",
                        new Taunt("I have underestimated you warrior..."),
                        new Suicide()
                        

                        )
                ),
                new Threshold(0.1,
                    new ItemLoot("Potion of Dexterity", 1.0) //I added this so people can easily add their own loot, however, feel free to remove this line. 1.0 = 100%.
                )
            );
        #endregion
    }
}