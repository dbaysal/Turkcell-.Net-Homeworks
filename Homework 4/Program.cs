using Homework_4;


//In this part, to understand covariant type parameters better I tried to
//generate base and derived objects from IActLike interface, to make it more clear to me,
//I used Parent and Children classes
//where Parent is base class of Children.
//With IActLike Interface I tried to represent the idea of Parents and Childrens
//acting like a Children sometimes but only parents have the responsibility to act like a parent.

Implementer<Parent> parentBehavior = new Implementer<Parent>();
Parent p1 = parentBehavior.Act();
//Children c1 = parentBehavior.Act();  COMPILE ERROR

Implementer<Children> childrenBehavior = new Implementer<Children>();
Parent p2 = childrenBehavior.Act();
Children c2 = childrenBehavior.Act();



//In this part, to understand contravariant type parameters,
//I represented the parameter as a place theme.
//So in this case only children can go inside to a place
//which is specifically designed for children, for example small parks.
//But I assumed all of the places designed for parents are considered to be appropriate to childrens as well.

Implementer<Children> childrenPlace = new Implementer<Children>();
Parent p3 = new Parent();
Children c3 = new Children();
//childrenPlace.GoInside(p3); COMPILE ERROR
childrenPlace.GoInside(c3);


Implementer<Parent> familyPlace = new Implementer<Parent>();
familyPlace.GoInside(c3);
familyPlace.GoInside(p3);