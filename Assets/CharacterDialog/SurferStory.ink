Hey, howza going bro?

-> bro_response
== bro_response==
  * Going great
    -> response1
  * Going bad
    -> response2
    

==response1==
That's so great
-> wanna_surf

==response2==
Cowabummer
-> wanna_surf
== wanna_surf===
Wanna Surf with me bro
 * Yes
 --- That's great let's go
    ->ending1
 
 
 * No 
 --- I understand
 ->ending2


==ending1===
- They surfed together like bros
-> END

==ending2===
- You just watched him surf and did nothing else
    -> END
