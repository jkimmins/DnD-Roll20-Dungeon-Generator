on("chat:message", function(msg)
{
    // If user types "!pm"
    if(msg.type == "api" && msg.content == "!pm")
    {
        // Finds the 'Positions' handout
        // Assumes only 1 handout is called 'Positions'
        var handout = findObjs({type: "handout", name: "Positions"})[0];
        // Gets the 'notes' section of the handout
        handout.get("notes", function(notes){
            // Removes paragraph tags
            var note = notes.replace("<p>", "")
            note = note.replace("</p>", "")
            note = note.replace("<br>", "")
            note = note.replace("&nbsp;", "")
            // Turns the note into an array
            note = note.split(" ");
            log(note);
            
            // Declares/initialises Variables
            var i;
            var x;
            var y;
            var tokenSize;
            var offset
            var name;
            var currentPageID = Campaign().get('playerpageid');
            var imgSource
            var ac;
            var hp;
            // For loop that will run through the note and place tokens in the correct spaces
            for (i = 0; i < note.length; i += 4)
            {
                x = note[i];
                y = note[i + 1];
                tokenSize = note[i + 2];
                tokenName = note[i + 3];
                
                switch(tokenSize)
                {
                    case "Tiny":
                        tokenSize = 0.5;
                        offset = 35;
                        break;
                    case "Small":
                        tokenSize = 1;
                        offset = 35;
                        break;
                    case "Medium":
                        tokenSize = 1;
                        offset = 35;
                        break;
                    case "Large":
                        tokenSize = 2;
                        offset = 0;
                        break;
                    case "Huge":
                        tokenSize = 3;
                        offset = -35;
                        break;
                    case "Gargantuan":
                        tokenSize = 4;
                        offset = -70;
                        break;
                    default:
                        tokenSize = 1;
                        offset = 35;
                }
                
                switch(tokenName)
                {
                    case "Goblin":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/26965533/51FC7wKMe8VXkXkAp1iMsw/thumb.png?5";
                        ac = 15;
                        hp = 7;
                        break;
                    case "Hobgoblin":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219460555/aqylaM1RKE3Xa8-iMGswmw/thumb.png?16198797775";
                        ac = 18;
                        hp = 11;
                        break;
                    case "Worg":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219462776/TkBUIJ2UheYyvBEv8VxM0Q/thumb.png?16198801405";
                        ac = 13;
                        hp = 26;
                        break;
                    case "Bugbear":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/170686223/IXOAja6ACScx6QPsERW2fA/thumb.png?16027067675";
                        ac = 16;
                        hp = 27;
                        break;
                    case "Ogre":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219458792/M0vXei-R1CHPy2aRarkPWg/thumb.png?16198792815";
                        ac = 11;
                        hp = 59;
                        break;
                    case "Troll":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/155568441/f6uOirdffotJCtHJZrMF2w/thumb.png?15966650795";
                        ac = 15;
                        hp = 84;
                        break;
                    case "Skeleton":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219464799/0BhHEasF13JdKUxR9m_tMQ/thumb.png?16198807065";
                        ac = 13;
                        hp = 13;
                        break;
                    case "Zombie":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219464958/yk2ZWbf5txuJ9GOYDFwxHA/thumb.png?16198807525";
                        ac = 8;
                        hp = 22;
                        break;
                    case "Shadow":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/170795212/WhqJVxt5tivpTPWe3X3PNw/thumb.jpg?16027636485";
                        ac = 12;
                        hp = 16;
                        break;
                    case "Ghoul":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219465112/Yl0YN7pEnQjGMod926lgaA/thumb.png?16198807925";
                        ac = 12;
                        hp = 22;
                        break;
                    case "Specter":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219465232/dpLDrZ_2zYZfP08qOpPlgA/thumb.png?16198808335";
                        ac = 12;
                        hp = 22;
                        break;
                    case "Ghast":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219465354/FLe4LvsVrMraQ6Cod-fYag/thumb.png?16198808735";
                        ac = 13;
                        hp = 36;
                        break;
                    case "Minotaur_Skeleton":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219465500/-Pm0qdfD2HekKt18XdwiKw/thumb.png?16198809095";
                        ac = 12;
                        hp = 67;
                        break;
                    case "Ogre_Zombie":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219465603/fjnzByHDuyct2jvv8ChjYA/thumb.png?16198809425";
                        ac = 8;
                        hp = 85;
                        break;
                    case "Will-o-Wisp":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219465709/OH54NofuhwLKM2FpjfIPbQ/thumb.png?16198809805";
                        ac = 19;
                        hp = 22;
                        break;
                    case "Wight":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219465840/L7OGJXIqL1KqNQMoC5oGQA/thumb.png?16198810305";
                        ac = 14;
                        hp = 45;
                        break;
                    case "Ghost":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219465957/acrDidYdI1aVGV8jPy2bJw/thumb.png?16198810635";
                        ac = 11;
                        hp = 45;
                        break;
                    case "Wraith":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219466047/FvTp-wx8_MXtlCVLlIwIDw/thumb.png?16198810975";
                        ac = 13;
                        hp = 67;
                        break;
                    case "Bandit":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/155567928/typbQbJUADXQ7nMd0zn1KA/thumb.png?15966649605";
                        ac = 12;
                        hp = 11;
                        break;
                    case "Wolf":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219458852/oqe4IZUG-AGMFO4ixm2IzA/thumb.png?16198793015";
                        ac = 13;
                        hp = 11;
                        break;
                    case "Thug":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/163688655/_6VNKM3thmst4_7h7As5jw/thumb.png?15998229825";
                        ac = 11;
                        hp = 32;
                        break;
                    case "Bandit_Captain":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/170690574/o4Gzhfn830QqzkwC2bb4DA/thumb.jpg?16027083535";
                        ac = 15;
                        hp = 65;
                        break;
                    case "Veteran":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219466183/tPXvJYuO4cf7M2hs7CIW4Q/thumb.png?16198811375";
                        ac = 17;
                        hp = 58;
                        break;
                    case "Gladiator":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219466302/ObF-LZxlASjzOGHiokqKfQ/thumb.png?16198811735";
                        ac = 16;
                        hp = 112;
                        break;
                    case "Cultist":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219466418/r4VYpDaB67wXRcW4vqwnFw/thumb.png?16198812095";
                        ac = 12;
                        hp = 9;
                        break;
                    case "Acolyte":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219466534/93WcBXl8jx97Q6WY5PcXsA/thumb.png?16198812445";
                        ac = 10;
                        hp = 9;
                        break;
                    case "Cult_Fanatic":
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/219466626/AIWDY6u2CA79ioo1-gmkyQ/thumb.png?16198812715";
                        ac = 13;
                        hp = 33;
                        break;
                    default:
                        imgSource = "https://s3.amazonaws.com/files.d20.io/images/27285986/U7ln5klQhSOE1SwGB-FQ-Q/thumb.png?5";
                }
                
                createObj('graphic', {left: (x*70)-offset,
                                        top: (y*70)-offset,
                                        width: 70*tokenSize,
                                        height: 70*tokenSize,
                                        name: tokenName,
                                        imgsrc: imgSource,
                                        pageid: currentPageID,
                                        bar1_value: hp,
                                        bar1_max: hp,
                                        bar2_value: ac,
                                        layer: "objects"});
            }
        }
        )
    }
}
);