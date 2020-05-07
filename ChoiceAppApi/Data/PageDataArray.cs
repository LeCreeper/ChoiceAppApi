using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChoiceAppApi.Model;

namespace ChoiceAppApi.Data
{
    public class PageDataArray
    {
        public PageData[] PageData { get; set; }

        public PageDataArray()
        {
            PageData = new PageData[]
            {
                //  SCENE 1 
                new PageData(
                    0, 
                    "The Flying Dane",
                    "You are a passenger aboard the mighty airship, The Flying Dane, a true marvel of science and engineering. The ship is headed for the city of Arcadia. " +
                    "It is early morning and you wake up in your cabin. " +
                    "What will you do? ",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Stroll around the ship.", 1),
                        new ButtonData(2,"Go back to sleep.", 2),
                        new ButtonData(3,"Believe in your avian ancestry and jump off the ship to fly like a bird.", 3), 
                    }),

                //  SCENE 1 - OPTION 1
                new PageData(
                    1,
                    "Stroll around the ship.",
                    "You get dressed, finish your morning rituals and begin to stroll around the ship, intent on exploring every crook and every cranny, ignoring the looks that the crew gives you.", 
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue", 4),
                        new ButtonData(2,"Go Back", 0),
                        
                    }),

                //  SCENE 1 - OPTION 2
                new PageData(
                    2,
                    "Go back to sleep.",
                    "You decide that you aren’t gonna deal with anyone or anything today, and go back to sleep. What’s the worst that could happen right? " +
                    "A few hours later you wake up in your bed, in the middle of the forest with no sign of the airship. " +
                    "Confused you stand up and look around for any signs of what happened. ",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"The Forest", 20),
                        new ButtonData(2,"Go Back", 0),
                        
                    }),

                //  SCENE 1 - OPTION 3
                new PageData(
                    3,
                    "Believe in your avian ancestry and jump off the ship to fly like a bird.",
                    "Today is the day! Today you will finally prove to everyone how wrong they were. " +
                    "You burst out of your cabin and head straight for the railing, not a single doubt in your mind that you will sprout the most majestic wings and fly with the birds…… " +
                    "A loud THUD! is heard as you hit the ground hard. " +
                    "What on earth were you thinking?",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 0),
                        
                    }),

                //  SCENE 2
                new PageData(
                    4,
                    "Smoke From below.",
                    "While happily exploring the ship, you suddenly encounter the sound of mechanical whirring, but this sound differently than the rest of the ship. " +
                    "Curiosity gets the better of you and you follow the sound, till you notice a small amount of smoke coming from the lower decks, out of the engine room... " +
                    "What will you do?",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Try to alert the crew.", 5),
                        new ButtonData(2,"Go check out the smoke for yourself", 6),
                        new ButtonData(3,"Enter a state of sheer and utter panic", 7),
                    }),

                //  SCENE 2 - OPTION 1
                new PageData(
                    5,
                    "Try to alert the crew.",
                    "You run and find the nearest crewmate to inform about the smoke, and you are told to head to the engine room to find the lead engineer in an attempt to fix it. " +
                    "So you head towards the engine room. ",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue.", 8),
                        new ButtonData(2,"Go Back.", 4),

                    }),

                //  SCENE 2 - OPTION 2
                new PageData(
                    6,
                    "Go check out the smoke for yourself.",
                    "In a rush of heroism and adrenaline, you head towards the smoke, hoping to find the source of it and fix it. ",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 8),
                        
                    }),

                //  SCENE 2 - OPTION 3
                new PageData(
                    7,
                    "Enter a state of sheer and utter panic.",
                    "You think about all the lives on board, all of the casualties in the event of a crash…. " +
                    "and you panic and run as fast as you can around the ship screaming “The ship is on fire!” until finally a crewmate has had enough of your ramblings and throw you overboard.",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 4),
                        
                    }),

                //  SCENE 3
                new PageData(
                    8,
                    "Engine Room",
                    "You follow the smoke to the engine room. As you enter, you realize it is hard to see anything through the thick smoke, " +
                    "but you manage to spot the glow of small fires coming from some of the mechanical engines. As you make your way towards the engines, " +
                    "you stumble over the body of a passed out engineer, with a half-filled bottle in his hands. " +
                    "What will you do?",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Attempt to put out the fire with your bare hands.", 9),
                        new ButtonData(2,"Try to wake up the Engineer.", 10),
                        new ButtonData(3,"Throw the contents of the Engineers bottle on the fire. ", 11),
                    }),

                //  SCENE 3 - OPTION 1
                new PageData(
                    9,
                    "Attempt to put out the fire with your bare hands.",
                    "Ignoring the logical part of your brain, your rush forward to put out the fire with your bare hands. " +
                    "While the pain doesn’t stop you, the smoke most certainly does and you soon pass out next to the engineer, never to wake up again.",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 8),
                        
                    }),

                //  SCENE 3 - OPTION 2
                new PageData(
                    10,
                    "Try to wake up the Engineer.",
                    "You go over to the engineer and crouch down next to him, in the hopes of waking him up.",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue", 12),
                        new ButtonData(2,"Go Back", 8),
                        
                    }),

                // SCENE 3 - OPTION 3
                new PageData(
                    11,
                    "Throw the contents of the Engineers bottle on the fire. ",
                    "In a heartbeat, you take the bottle from the engineer and rush over to the engines and throw the contents of the bottle at the fire. " +
                    "The fire rages out of control and the fire quickly spreads to the rest of the ship. " +
                    "Unfortunately for you, it doesn’t appear that the bottle contained water, and the engineer likely didn’t pass out due to the room filling with smoke.",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 8),
                        
                    }),

                //  SCENE 4
                new PageData(
                    12,
                    "Engineer Closeup",
                    "As you kneel down besides the unconscious engineer, you notice the stench of booze on him and a loud snoring, " +
                    "and your mind races to find ways to wake the poor man up, so he can put out the fire. " +
                    "What will you do?",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Attempt to wake him up with the contents of his bottle.", 13),
                        new ButtonData(2,"Let him know the rum is gone.", 14),
                        new ButtonData(3,"Scream at him that there is a fire, and shake him till he wakes.", 15),
                    }),

                //  SCENE 4 - OPTION 1
                new PageData(
                    13,
                    "Attempt to wake him up with the contents of his bottle.",
                    "You grab the bottle, and quickly empty the contents over the engineer’s face. Sadly all you achieve is him licking his lips and snoring even louder. " +
                    "The fire quickly spirals out of control and the ship soon turns into a raging fireball.",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 12),
                        
                    }),

                // SCENE 4 - OPTION 2
                new PageData(
                    14,
                    "Let him know the rum is gone.",
                    "As you mutter to yourself, wondering what he drank, you whisper the word “rum” and the engineer immediately springs to life demanding to know why his rum is gone, " +
                    "before quickly rushing to put out as much of the fire he can and attempting to salvage the situation.",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue.", 16),
                        new ButtonData(2,"Go Back", 12),
                        
                    }),

                //  SCENE 4 - OPTION 3
                new PageData(
                    15,
                    "Scream at him that there is a fire, and shake him till he wakes.",
                    "You violently grab the engineer by his clothes and shake him in a desperate attempt to wake him from his stupor, " +
                    "he simply grunts in his sleep, and clutches his rum even tighter, like a teddy bear. " +
                    "The fire quickly spirals out of control and the ship soon turns into a raging fireball.",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 12),
                    }),

                //  SCENE 5
                new PageData(
                    16,
                    "Crash Course.",
                    "With your combined effort, you and the engineer manages to extinguish the fire, and the engineer rush to the enginees, " +
                    "however at this moment it’s far too late to save the engines and the ship begins to nose dive. " +
                    "What will you do? ",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Refuse to accept the engines’ surrender and punish them.", 17),
                        new ButtonData(2,"Wait for the ship to get closer to the ground and then jump to the safety of a tree.", 18),
                        new ButtonData(3,"Go back to bed.", 19),
                    }),

                //  SCENE 5 - OPTION 1
                new PageData(
                    17,
                    "Refuse to accept the engines’ surrender and punish them. ",
                    "You kick the engines repeatedly until suddenly they activate… but in reverse, and the ship crashes into the island at full speed. ",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 16),
                        
                    }),

                // SCENE 5 - OPTION 2
                new PageData(
                    18,
                    "Wait for the ship to get closer to the ground and then jump to the safety of a tree.",
                    "In a moment of lunacy you decide to go to the upper deck, and wait for the ship to get close to the ground. As the ground is closing in quickly, " +
                    "you jump towards a tree in the forest below, and land on the top of the tree! " +
                    " … only to fall through the many leaves and branches, " +
                    "which miraculously slows your fall enough that you land safely on the ground.",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue",20),
                        new ButtonData(2,"Go Back", 16),
                        
                    }),

                // SCENE 5 - OPTION ´3
                new PageData(
                    19,
                    "Go back to bed.",
                    "With no options left, you decide that you’ve had enough and decide to go back to your cabin and go to sleep. " +
                    "Tomorrow will be better. A few hours later you wake up in your bed in the middle of the forest with no sign of the airship. " +
                    "Confused you stand up and look around for any signs of what happened.",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue", 20),
                        new ButtonData(2,"Go Back", 16),
                        
                    }),

                //  SCENE 6
                new PageData(
                    20,
                    "The Forest",
                    "Surrounded by trees and bushes, you try to figure out where exactly you are, and notice a pillar of smoke in the distance, but before you can react, " +
                    "you begin to hear footsteps and faint voices slowly getting closer. " +
                    "What will you do? ",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go to the source of the sounds.", 21),
                        new ButtonData(2,"Hide in the bushes and wait for the source of the footsteps.", 22),
                        new ButtonData(3,"Run in the opposite direction.", 23),
                    }),

                // SCENE 6 - OPTION 1
                new PageData(
                    21,
                    "Go to the source of the sounds.",
                    "It turns out that the voices belong to a group of goblins. Very hungry-looking goblins. " +
                    "It also turns out that you seem to taste quite good. Your adventure ends in a soup pot.",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back.", 20),
                        
                    }),

                // SCENE 6 - OPTION 2
                new PageData(
                    22,
                    "Hide in the bushes and wait for the source of the footsteps.",
                    "Not feeling particularly brave, you hide in the nearby bushes and wait for whatever is making the sounds, " +
                    "and you watch as a group of goblins pass you, unaware of your presence.",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue", 24),
                        new ButtonData(2,"Go Back", 20),
                        
                    }),

                // SCENE 6 - OPTION 3
                new PageData(
                    23,
                    "Run in the opposite direction.",
                    "You run as fast as you can in the opposite direction and into the forest. " +
                    "Unfortunately, this is very foreign land, and the forest appears to get quite deep. So deep that this is the last that’s ever heard of you. ",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 20),
                        
                    }),

                //  SCENE 7
                new PageData(
                    24,
                    "The Lake",
                    "After the goblins are a safe distance away, and you’re confident you won’t be noticed, you exit your hiding place, and start walking towards the smoke in the distance. " +
                    "After a while, you come to a lake, with a beautiful woman standing in the middle of the lake, her feet standing motionless on the surface of the water. " +
                    "You notice she is holding a sparkling sword, and is beckoning you closer. " +
                    "What will you do? ",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Walk away.", 25),
                        new ButtonData(2,"Flirt with her.", 26),
                        new ButtonData(3,"Ask nicely for the shiny sword.", 27),
                    }),

                // SCENE 7 - OPTION 1
                new PageData(
                    25,
                    "Walk away.",
                    "You decide that you don’t really like fairy tales anyway, so you turn around and start to leave. " +
                    "Shortly after, you can hear her yell something about “rude behavior” and before you manage to even blink, the sword is sitting deeply in the tree right beside your head. " +
                    "You take the sword and hurry away before she finds anything else to throw after you.",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue", 28),
                        new ButtonData(2,"Go Back", 24),
                        
                    }),

                // SCENE 7 - OPTION 2
                new PageData(
                    26,
                    "Flirt with her.",
                    "You approach the woman, and figure that this is your chance to use some of your legendary charm, " +
                    "and you begin to flirt with her. Sadly, her response is less than ideal as she immediately grabs the sword and slice you into a 1000 pieces. ",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 24),
                        
                    }),

                // SCENE 7 - OPTION 3
                new PageData(
                    27,
                    "Ask nicely for the shiny sword.",
                    "You approach the woman, and politely ask her if you can borrow the sword for your journey to find safety and help. " +
                    "She smiles and tells you that you are the one she has been waiting for, and hands you the sword, before disappearing into the lake.You continue towards the smoke. ",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue", 28),
                        new ButtonData(2,"Go Back", 24),
                        
                    }),

                // SCENE 8
                new PageData(
                    28,
                    "The Cave.",
                    "Following the smoke you reach a large cave. As you enter, your sword lights up the darkness and allows you to see where you are going. " +
                    "Eventually you find a strangely well dressed cave troll, who strikes up a polite conversation with you. Turns out he strongly believes in communism and his name is Paul. " +
                    "He is trying to perfect a new soup recipe. Behind him you see the exit of the cave. " +
                    " What will you do?",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Attack him.", 29),
                        new ButtonData(2,"Trade the sword in exchange for safe passage.", 30),
                        new ButtonData(3,"Offer to help him with the soup.", 31),
                    }),

                // SCENE 8 - OPTION 1
                new PageData(
                    29,
                    "Attack him.",
                    "You quickly strike Paul with your sword, while he is distracted. " +
                    "Unfortunately, sword seems to not hurt him at all, and he looks at you angrily, " +
                    "before smacking you so hard into the ground, that only archaeologists will have a chance of finding you.",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back", 28),
                        
                    }),

                // SCENE 8 - OPTION 2
                new PageData(
                    30,
                    "Trade the sword in exchange for safe passage.",
                    "You notice that Paul seem to be quite interested in your shiny sword, and you offer to give it to him in exchange for safe passage through the cave. " +
                    "Paul seem quite confused, but agrees happily, and you continue on your way. ",
                    false,
                    true,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Continue", 32),
                        new ButtonData(2,"Go Back", 28),
                        
                    }),

                // SCENE 8 - OPTION 3
                new PageData(
                    31,
                    "Offer to help him with the soup",
                    "You offer to help Paul with the soup and together you manage perfect the soup, while discussing the various aspects of communism. " +
                    "By the time the soup is done you realize you’ve never had a friend like paul, and together you venture out into the world to share your amazing soup with everyone. " +
                    "The soup soon becomes famous, and so do you and Paul, earning enough money to spread the wisdom of communism around the world..",
                    true,
                    false,
                    true,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back.", 28),
                        
                    }),

                // SCENE 9
                new PageData(
                    32,
                    "Town Gate",
                    "As you exit the cave, you realize the smoke is coming from a small town, and as you approach you are met at the gate by a town guard. " +
                    "Quickly he grabs his weapon and asks you what you are doing there. " +
                    "What will you do. ",
                    false,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Tell him your story.", 33),
                        new ButtonData(2,"Tell him you had a bad day and just want to get in.", 34),
                        new ButtonData(3,"Believe in your avian ancestry.", 35),
                    }),

                // SCENE 9 - OPTION 1
                new PageData(
                    33,
                    "Tell him your story.",
                    "You begin to tell the guard the story of what happened during your journey. Halfway through, he calls the local doctor,  " +
                    "and a few other guards, to bring you  to the local asylum, where you get a free bed and meals for the rest of your life. " +
                    "Whether you want to or not.",
                    true,
                    false,
                    false,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back.", 32),
                        
                    }),

                // SCENE 9 - OPTION 2
                new PageData(
                    34,
                    "Tell him you had a bad day and just want to get in.",
                    "He gives you an understanding look, nods empathically, and pats you on the shoulder, before stepping aside so you can finally enter the town. " +
                    "Booze at the local tavern, oh! so fantastic and a happy daily life awaits you.",
                    true,
                    false,
                    true,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back.", 32),
                        
                    }),

                // SCENE 9 - OPTION 3
                new PageData(
                    35,
                    "Believe in your avian ancestry.",
                    "As you close your eyes, you soon feel a change happening inside you, you feel lighter and you notice wind on your face that wasn’t there before, " +
                    "and as you open your eyes you realize you are flying in the air. Finally you can prove every non-believer wrong and you soar into the sky and fly out in the sunset.",
                    true,
                    false,
                    true,
                    new ButtonData[]
                    {
                        new ButtonData(1,"Go Back.", 32),
                        
                    }),




            };
        }
    }
}
