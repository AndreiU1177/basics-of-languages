class Question:
    def __init__(self, q, a):
        self.q = q
        self.a = a
class Student:
    def __init__(self, name, profile, rating):
        self.name = name            #no need to use the function __init__ if the object created has no attributes
        self.profile = profile
        self.rating = rating

    def on_honor_roll(self):
        if self.rating >= 3.5:
            return True
        else:
            return False
