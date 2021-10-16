# hello_world.py
# A really long program in order to condense the basics into one easy learning exercise
# This would normally be split into multiple smaller programs.


#This is a single line comment

# You could however put a single line
# onto multiple line like this.
# That would still be acceptable.

"""
This is a multiline comment.
Like the one above but different.
Python ignores 'String literals' unless they are assigned to a variable.
So use triple quotes at the start and finish in order to do this.
"""


print("Hello World!")


x = "awesome"

def myfunc():
  x = "fantastic"
  print("Python is " + x)

myfunc()

print("Python is " + x)