package com.cm.jpa_boot_01.controller;

import com.cm.jpa_boot_01.model.Board;
import com.cm.jpa_boot_01.model.Greeting;
import com.cm.jpa_boot_01.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.Arrays;
import java.util.List;
import java.util.concurrent.atomic.AtomicLong;

@Controller
public class GreetingController {

    @Autowired
    BoardRepository boardRepository;

    @GetMapping("/greeting")
    public String greeting(@RequestParam(name="name", required=false, defaultValue="World") String name, Model model) {
        model.addAttribute("name", name);
        return "greeting";
    }

    @GetMapping("/")
    public String home(){
        return "home";
    }

    @GetMapping("board")
    public String board(Model model) {
//        List<Board> list = Arrays.asList(
//                new Board(1l, "board1", "title1", "content1", "20210916"),
//                new Board(2l, "board2", "title2", "content2", "202210917")
//        );
        List<Board> list = boardRepository.findAll();
        model.addAttribute("list", list);
        return "board/board";
    }
}
