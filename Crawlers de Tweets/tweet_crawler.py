from tweepy.streaming import StreamListener
from tweepy import OAuthHandler
from tweepy import Stream

access_token = "1051915230169767937-rhS19cPpyeB1SqSb6nQWopq0ZZ7z5h"
access_token_secret="MdwORqbRkBZJb394WD83TMZYqcENu8JmVjEzKMvTeNn2w"
consumer_key="h3fxC625V0J5tzvUnG0IRTf1A"
consumer_secret="oe8hlopFhVONUXbc2aTDILNktKKuttDSFOmk4raJSR1ypWR6X3"

class StdOutListener(StreamListener):

    def on_data(self,data):
        print (data)
        return True

    def on_error(self,status):
        print (status)

if __name__ == '__main__':
    # Autenticando Dados e conectando na API do TT
    l = StdOutListener()
    auth = OAuthHandler(consumer_key, consumer_secret)
    auth.set_access_token(access_token, access_token_secret)
    stream = Stream(auth,l)

    stream.filter(track =['skybrasil','skyresponde'])