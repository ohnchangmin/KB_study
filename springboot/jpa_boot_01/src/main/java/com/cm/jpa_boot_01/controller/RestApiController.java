package com.cm.jpa_boot_01.controller;

import com.cm.jpa_boot_01.model.Board;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping
public class RestApiController {

    // DB table board -> List collection 여러개의 행
    @GetMapping("list")
    public ResponseEntity<?> list() {
        return null;
    }

    //
    @GetMapping("test")
    public Board one() {
        return new Board(1l, "name", "title", "content", "date");
    }
}
