import random

R_EATING="I don't like eating anything because I'm bot obviously"

def unknown():
    response=['Could you please re-pharse that?',
              "...",
              "I'm not sure I follow. Could you explain further?"
              "Interesting. Tell me more about that.",
              "Hmm, I'm not familiar with that. Could you provide more details?",
              "I see. Can you break it down for me a bit more?",
              "I'm intrigued. Could you provide additional context?",
              "That's a unique perspective. Could you expand on that?",
              "That's an interesting take. Can you share more of your thoughts on the matter?",
              "What does that mean?"]
    response = random.choice(response)  # Select a random response from the list
    return response