package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.RecyclingTip;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.RecyclingTipRepo;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;
import java.util.Optional;

@org.springframework.stereotype.Service
public class RecyclingTipService extends Service<RecyclingTip>{

    @Autowired
    private RecyclingTipRepo recyclingTipRepo;

    public List<RecyclingTip> getAll() {
        return recyclingTipRepo.findAll();
    }

    public Optional<RecyclingTip> getByID(Long id) {
        return recyclingTipRepo.findById(id);
    }

    public void deleteByID(Long id) {

        recyclingTipRepo.deleteById(id);
    }

    public RecyclingTip update(Long id, RecyclingTip newTip) {

        Optional<RecyclingTip> oldTip = getByID(id);

        if (oldTip.isPresent()) {

            newTip.setType(newTip.getType().toLowerCase());
            RecyclingTip updatedTip = oldTip.get();
            updatedTip.setTip(newTip.getTip());
            updatedTip.setType(newTip.getType());

            RecyclingTip tipData = recyclingTipRepo.save(updatedTip);

            return tipData;
        }
        return null;
    }

    public RecyclingTip save(RecyclingTip newTip) {

        newTip.setType(newTip.getType().toLowerCase());

        RecyclingTip tipData = recyclingTipRepo.save(newTip);
        return tipData;
    }
}
