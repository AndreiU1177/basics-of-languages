public final class Teacher extends User implements Methods_for_persons {
	//final class cannot be inherited
	public Teacher(String fn) {
		setFirstName(fn);
	}
	@Override
	public void sayHello() {
		System.out.println("Hi, i am a teacher");
	}
}
