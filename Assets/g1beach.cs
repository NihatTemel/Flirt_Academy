using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g1beach : MonoBehaviour
{

    public List<string> GirlDialog = new List<string>();

    public List<int> LoseList = new List<int>() { 19 };

    public List<int> WinList = new List<int>() { 11 };

    public int winstep = 3;

    int childindex = 0;

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            string strn = "" + i;
            GirlDialog.Add(strn);

        }

        childindex = transform.GetSiblingIndex();

      

        //PlayerPrefs.SetString("language", "tr");




    }


    public void DialogLanguageEn()
    {
        if (PlayerPrefs.GetString("language") != "tr")
        {
            switch (PlayerPrefs.GetInt("girl"))
            {
                case 0:
                    {
                        
                        girl1();
                        break;
                    }
                case 1:
                    {
                        Debug.Log("22");
                        girl2();
                        break;
                    }
                case 2:
                    {
                        Debug.Log("33");
                        girl3();
                        break;
                    }
                case 3:
                    {
                        Debug.Log("44");
                        girl4();
                        break;
                    }
                case 4:
                    {
                        girl5();
                        break;
                    }
                case 5:
                    {
                        girl6();
                        break;
                    }
                case 6: // park
                    {
                        girl7();
                        break;
                    }
                case 7:
                    {
                        girl8();
                        break;
                    }
                case 8:
                    {
                        girl9();
                        break;
                    }
                case 9:         //game center
                    {
                        girl10();
                        break;
                    }
                case 10:
                    {
                        girl11();
                        break;
                    }
                case 11:
                    {
                        girl12();
                        break;
                    }

            }
        }
    }


    void girl1()
    {
       
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Hello, I'm happy you came to the beach. What are you doing here?";
        GirlDialog[2] = "Isn't the weather really hot?";
        GirlDialog[3] = "The beach looks really swampy.";

        GirlDialog[4] = "I like walking on the beach on a beautiful day.";
        GirlDialog[5] = "Isn't the smell of this beach disturbing?";
        GirlDialog[6] = "The sun makes you feel good.";
        GirlDialog[7] = "This beach is really ugly.";

        GirlDialog[8] = "I completely agree with you. I'm a summer person.";
        GirlDialog[9] = "You must think highly of yourself.";
        GirlDialog[10] = "I'm a winter person.";
        GirlDialog[11] = "I think it's destiny that we met.";

        GirlDialog[12] = "I'm glad to have met you.";
        GirlDialog[13] = "This pleasure is mine.";
    }




    void girl2()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I know, you came here for me.";
        GirlDialog[2] = "Do you need sunscreen?";
        GirlDialog[3] = "Is this your first time here? Isn't the weather nice?";

        GirlDialog[4] = "Yes. I came here on vacation.";
        GirlDialog[5] = "What a coincidence, I'm here for the first time in years as well.";
        GirlDialog[6] = "You seem to be always traveling and getting dirty.";
        GirlDialog[7] = "I guess you have a lot of money.";

        GirlDialog[8] = "How nice, do you have any recommendations for things to do here on the beach?";
        GirlDialog[9] = "Be careful, there are a lot of sharks here.";
        GirlDialog[10] = "Being with me is my biggest recommendation.";
        GirlDialog[11] = "How about we have a coffee in the cafe up ahead?";

        GirlDialog[12] = "It sounds very appealing to me.";
        GirlDialog[13] = "You are more appealing.";
    }

    void girl3()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Are you having fun here?";
        GirlDialog[2] = "Good day, what are you doing on this beautiful day?";
        GirlDialog[3] = "Is that smell coming from you?";
        GirlDialog[4] = "I'm sunbathing. How about you?";

        GirlDialog[5] = "You've put a damper on my mood.";
        GirlDialog[6] = "This doesn't concern you.";
        GirlDialog[7] = "I think I'm having the best day of my vacation.";
        GirlDialog[8] = "That is interesting, Why?";

        GirlDialog[9] = "Talking to you is enough for that.";
        GirlDialog[10] = "Does this concern you?";
        GirlDialog[11] = "I'm actually keeping the answer to that a secret.";

        GirlDialog[12] = "You're very sweet. Thank you.";
        GirlDialog[13] = "It's wonderful to meet you.";

    }

    void girl4()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You're poorly dressed for this place.";
        GirlDialog[2] = "Are you an elite person?";
        GirlDialog[3] = "You are the most beautiful piece in this museum.";
        GirlDialog[4] = "Thank you. Are you interested in art?";

        GirlDialog[5] = "My great-grandparents were all artists.";
        GirlDialog[6] = "I come here to see beautiful women.";
        GirlDialog[7] = "I am art itself.";
        GirlDialog[8] = "You're really funny.";

        GirlDialog[9] = "Yes, I am.";
        GirlDialog[10] = "What's funny about that?";
        GirlDialog[11] = "I'm happy to have made you smile.";

        GirlDialog[12] = "I think it's my lucky day.";
        GirlDialog[13] = "I feel like I've won the lottery.";

    }

    void girl6()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "What are you looking for in the museum?";
        GirlDialog[2] = "What's the most interesting thing you've seen in this museum?";
        GirlDialog[3] = "Museums don't seem to be your thing.";
        GirlDialog[4] = "The antique Chinese vases looked very beautiful.";

        GirlDialog[5] = "You look more antique.";
        GirlDialog[6] = "I didn't particularly like those antiques.";
        GirlDialog[7] = "I can't believe it. I agree with you.";
        GirlDialog[8] = "Our meeting here must be fate.";
        GirlDialog[9] = "I believe in fate. I feel something different now.";
        GirlDialog[10] = "Fate seems a bit ridiculous to me.";
        GirlDialog[11] = "I don't think you're very smart.";
        GirlDialog[12] = "I'm glad we met.";
        GirlDialog[13] = "May our happiness last forever.";

    }

    void girl5()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "These museums are so expensive.";
        GirlDialog[2] = "Hello, do you know how old this museum is?";
        GirlDialog[3] = "Don't museums seem meaningless?";
        GirlDialog[4] = "How old?";
        GirlDialog[5] = "The oldest pieces date back to pre-millennial years.";
        GirlDialog[6] = "I don't know either.";
        GirlDialog[7] = "You seem quite ignorant.";
        GirlDialog[8] = "You seem very knowledgeable. I am impressed.";
        GirlDialog[9] = "How about we have a coffee after the museum?";
        GirlDialog[10] = "I am very impressive.";
        GirlDialog[11] = "I leave such an impact on women.";
        GirlDialog[12] = "Sounds Great";
        GirlDialog[13] = "We have a deal then.";


    }

    void girl7()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Is that smell coming from you?";
        GirlDialog[2] = "This park is really creepy.";
        GirlDialog[3] = "It's a beautiful evening, isn't it?";
        GirlDialog[4] = "Yes, the weather is great.";
        GirlDialog[5] = "Do you want to run a race?";
        GirlDialog[6] = "You're very beautiful.";
        GirlDialog[7] = "You're what makes this place beautiful.";
        GirlDialog[8] = "Thank you.";
        GirlDialog[9] = "Do you want to go for a walk here tomorrow?";
        GirlDialog[10] = "You're so cold.";
        GirlDialog[11] = "Your glasses look funny.";
        GirlDialog[12] = "Definitely, let's do that.";
        GirlDialog[13] = "I'm glad we met.";
    }

    void girl8()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Are you the angel of this park?";
        GirlDialog[2] = "Shall we have a coffee?";
        GirlDialog[3] = "Isn't this a great park?";
        GirlDialog[4] = "This is my favorite park in the city.";
        GirlDialog[5] = "This is a great choice for relieving the stress of the city.";
        GirlDialog[6] = "Are you maybe exaggerating a bit?";
        GirlDialog[7] = "I know a better place.";
        GirlDialog[8] = "It really is, quiet and enchanting.";
        GirlDialog[9] = "You're funny.";
        GirlDialog[10] = "Is it the park or you?";
        GirlDialog[11] = "Come on, let me buy you to a meal.";
        GirlDialog[12] = "You're sweet. Thank you.";
        GirlDialog[13] = "I'm very glad to met you.";
    }

    void girl9()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Did you get lost?";
        GirlDialog[2] = "Are you taking a walk";
        GirlDialog[3] = "You're very beautiful.";
        GirlDialog[4] = "Yes. Why?";
        GirlDialog[5] = "I go for a walk here every day. I've never seen you before.";
        GirlDialog[6] = "You're walking slowly.";
        GirlDialog[7] = "You need to lose some weight.";
        GirlDialog[8] = "I came here on vacation.";
        GirlDialog[9] = "I hope the vacation ends soon.";
        GirlDialog[10] = "I didn't ask that.";
        GirlDialog[11] = "This park is very beautiful, it's even more beautiful with you.";
        GirlDialog[12] = "Thank you. You made me feel good.";
        GirlDialog[13] = "I'm glad you think like that.";
    }

    void girl10()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "This arcade must be boring.";
        GirlDialog[2] = "This place is not for you.";
        GirlDialog[3] = "I'm new here. Do you have any recommendations for a game?";
        GirlDialog[4] = "Sure. What kind of games do you like?";
        GirlDialog[5] = "To be honest, I don't really like games.";
        GirlDialog[6] = "I'm good at all of them.";
        GirlDialog[7] = "I'll leave it up to your preference.";
        GirlDialog[8] = "In that case, I recommend the dance competition game.";
        GirlDialog[9] = "That game is only for girls.";
        GirlDialog[10] = "Why not if we play against each other?";
        GirlDialog[11] = "I didn't like this game.";
        GirlDialog[12] = "It looks like it will be fun.";
        GirlDialog[13] = "I feel the same way.";
    }
    void girl11()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Are you a wizard? Every time I look at you, everyone disappears.";
        GirlDialog[2] = "Are you part of the game here? You're too beautiful to be real.";
        GirlDialog[3] = "What game would you recommend for me to play?";
        GirlDialog[4] = "I love racing games.";
        GirlDialog[5] = "I'm not really into games to be honest.";
        GirlDialog[6] = "I play to win. Want to play together?";
        GirlDialog[7] = "I love racing games.";
        GirlDialog[8] = "Would you like to play together?";
        GirlDialog[9] = "If we're going to play, let's make it interesting and put a bet.";
        GirlDialog[10] = "I couldn't hear you because you are gorgeous";
        GirlDialog[11] = "With pleasure.";
        GirlDialog[12] = "Don't fall behind.";
        GirlDialog[13] = "I will always be by your side.";
    }

    void girl12()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You're really good. Can you give me some tips on the game?";
        GirlDialog[2] = "Are you a dream or a reality? Or is this just a game?";
        GirlDialog[3] = "The game I want to play is you.";
        GirlDialog[4] = "I am the champion of this game. Who are you?";
        GirlDialog[5] = "Let's say I'm a fan.";
        GirlDialog[6] = "That doesn't matter to me.";
        GirlDialog[7] = "You're the end of me.";
        GirlDialog[8] = "Very nice. What would you like to learn?";
        GirlDialog[9] = "I'm curious about attack strategies.";
        GirlDialog[10] = "Tell me how to beat you.";
        GirlDialog[11] = "Your phone number.";
        GirlDialog[12] = "I feel like want to play with you for hours.";
        GirlDialog[13] = "All of my time is yours.";
    }

}


