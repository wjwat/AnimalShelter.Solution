"""
Pretty simple script to use. Just pipe the output to whatever JSON file you'd
like to use with your database. Currently we've got it hardcoded to look for
`Animals.json` in the top level directory of `AnimalShelter.Api`

Ex:
$ python gen-db-entries.py > Animals.json
$ cp Animals.json /path/to/AnimalShelter.Api
"""

import json
import random

NUMBER_OF_ROWS = 50
ROWS = []
STATUS = [
  0, # Available
  1  # Adopted
]

def get_random_words(count, file = 'crayola-standard.txt'):
  with open(file) as f:
    words = f.readlines()
  return ' '.join([x.strip() for x in random.choices(words, k = count)])


for x in range(NUMBER_OF_ROWS):
  r = {"AnimalId": x+1,
       "Name": get_random_words(1),
       "Breed": get_random_words(1),
       "Species": get_random_words(1),
       "Description": get_random_words(50),
       "Status": random.choice(STATUS)}
  ROWS.append(r)


print(json.dumps(ROWS, indent=2))
