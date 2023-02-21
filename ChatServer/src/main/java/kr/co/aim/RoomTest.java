package kr.co.aim;

import org.springframework.beans.factory.annotation.Autowired;

import kr.co.aim.domain.Member;
import kr.co.aim.domain.MemberRoom;
import kr.co.aim.domain.Room;
import kr.co.aim.repository.MemberRepository;
import kr.co.aim.repository.MemberRoomRepository;
import kr.co.aim.repository.RoomRepository;

//@Component
public class RoomTest {
	@Autowired
	private RoomRepository roomRepository;
	@Autowired
	private MemberRoomRepository memberRoomRepository;
	@Autowired
	private MemberRepository memberRepository;
	
	public static void main(String[] args) {
		String type = "RN";
		System.out.println("".getBytes().length);
	}
	
	//@PostConstruct
	public void init() {
		Member member = new Member();
		member.setName("혜인");

		Room room = new Room();
		room.setName("헤이니4");
		room.setCapacity(3);
		
		MemberRoom memberRoom = new MemberRoom();
		memberRoom.setMember(member);
		memberRoom.setRoom(room);
		
		memberRepository.save(member);
		roomRepository.save(room);
		
		memberRoomRepository.save(memberRoom);
	}
}
