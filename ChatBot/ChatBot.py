import re
import long_responses as long



def message_Probability(user_message,recognised_words,single_response=False,required_words=[]):
    message_certainty=0
    has_required_word=True
    
    #Counts how many words are present in each predefined message
    for word in user_message:
        if word in recognised_words:
            message_certainty+=1

    #Calculate the percent of recognised words in a user message
    percentage=float(message_certainty)/float(len(recognised_words))     

    for word in required_words:
        if word not in user_message:
            has_required_word=False
            break

    if has_required_word or single_response:
        return int(percentage*100)
    else:
        return 0
    
# Function to check messages and determine the best response
def check_all_messages(message):
    highest_prob_list={}

    def response(bot_response,list_of_words,single_response=False,required_words=[]):
        nonlocal highest_prob_list
        highest_prob_list[bot_response]=message_Probability(message,list_of_words,single_response,required_words)

    #Response ....................................
    response('Hello! I\'m Bella, your chatbot specializing in Sri Lanka\'s IQ. How can I assist you today?',['hello','hi','sup','hey','heyo'],single_response=True)
    response('Goodbye!', ['bye', 'goodbye', 'see you later'], single_response=True)
    response('I\'m doing fine, and you?',['how','are','you','doing','how feel you'],required_words=['how'])
    response('I\'m here to help. What can I assist you with?', ['help', 'assist','can you help me'], required_words=['help'])
    response('The weather varies in Sri Lanka, ranging from sunny and hot to rainy and humid throughout the year. I can\'t mention accurately', ['weather', 'today'], required_words=['weather'])
    response('I enjoy learning new things. What interests you?', ['interests', 'you'], required_words=['like'])
    response('Thank you!',['i','love','code','palace'],required_words=['code','palace'])
    response('My name is Bella',['what','is','your','name'],required_words=['name'])
    response('I have two siblings',['how','many','family','members'],required_words=['family','members'])
    response('Sri Lanka has eight UNESCO World Heritage Sites, including Sigiriya and the ancient city of Polonnaruwa.', ['unesco world heritage sites', 'sigiriya', 'polonnaruwa'], required_words=['heritage'])
    response('The capital city of Sri Lanka is Sri Jayawardenepura Kotte, which is also the largest city in the country.', ['capital city', 'colombo'], required_words=['capital'])
    response('Sri Lanka is renowned for its diverse landscapes, from pristine beaches to lush tea plantations and ancient ruins.', ['diversity', 'beaches', 'tea plantations', 'ancient ruins'], required_words=['diversity'])
    response('The country is famous for Ceylon tea, known for its unique flavor and high quality.', ['ceylon tea','plant', 'unique flavor', 'high quality'], required_words=['plant'])
    response('Sri Lanka\'s national sport is volleyball, and cricket is immensely popular among its citizens.', ['national', 'sport', 'volleyball', 'cricket', 'popular'], required_words=['sport'])
    response('The population of Sri Lanka is approximately 22 million people.', ['population of sri lanka', '22 million people','population'], required_words=['population'])
    response('Sri Lanka boasts a rich cultural heritage, influenced by Buddhism, Hinduism, and various other cultures.', ['cultural' ,'heritage', 'buddhism', 'hinduism'], required_words=['cultural'])
    response('The island is home to a variety of wildlife, including elephants, leopards, and a diverse range of bird species.', ['wildlife', 'elephants', 'leopards', 'bird species'], required_words=['wildlife'])
    response('The climate in Sri Lanka is tropical, characterized by distinct wet and dry seasons.', ['climate', 'tropical', 'wet and dry seasons'], required_words=['climate'])
    response('The currency used in Sri Lanka is the Sri Lankan Rupee (LKR).', ['currency', 'sri lankan rupee'], required_words=['currency'])
    response('The national flower of Sri Lanka is the Blue Water Lily, also known as Nymphaea stellata.', ['blue water lily','flower', 'nymphaea stellata'], required_words=['flower'])
    response('The national bird of Sri Lanka is the Sri Lankan junglefowl, also known as Gallus lafayetii.', ['sri lankan junglefowl','bird', 'gallus lafayetii'], required_words=['bird'])
    response('The national tree of Sri Lanka is the Ironwood tree, also known as Manilkara hexandra.', ['tree', 'manilkara hexandra'], required_words=['tree'])
    response('The Sri Lankan flag features vibrant colors with two vertical bands of green and orange, representing different aspects of the country.', ['sri lankan flag', 'green', 'orange'], required_words=['flag', 'sri lanka'])
    response('The Ruwanwelisaya stupa in Anuradhapura is one of the largest stupas in Sri Lanka and is considered a sacred Buddhist site.', ['ruwanwelisaya stupa', 'anuradhapura', 'buddhist site'], required_words=['stupa'])
    response('The Sinhalese and Tamil are the official languages of Sri Lanka, reflecting its diverse cultural heritage.', ['languages', 'sinhalese', 'tamil'], required_words=['languages'])
    response('Sri Lanka gained its independence from British rule on February 4, 1948.', ['independence', 'february 4, 1948'], required_words=['independence'])
    response(long.R_EATING,['what','you','eat'],required_words=['you','eat'])


    best_match=max(highest_prob_list,key=highest_prob_list.get)
    #print(highest_prob_list)

    return long.unknown() if highest_prob_list[best_match]< 1  else best_match 
                 
# Function to get user response and interact with the bot
def get_response(user_input):
    split_message=re.split(r'\s+|[,;?!.-]\s*',user_input.lower())
    response=check_all_messages(split_message)
    return response

# Main loop for interacting with the bot
while True:
    print('Bella: ' + get_response(input('You: ')))